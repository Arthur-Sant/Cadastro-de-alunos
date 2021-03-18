using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cad_alunos_04_2d2
{
    public partial class frm_aluno : Form
    {
        public frm_aluno()
        {
            InitializeComponent();
        }
       

        ConexaoBd bd = new ConexaoBd();
        string sql;
        string foto;

        public void Listar()
        {
            sql = "select id as Matricula, Nome, dt_nascimento as Data_de_nascimento, Sexo, foto, Nota from alunos";
            dgv_listar.DataSource = bd.ConsultarTabelas(sql);
        }

        public void Limpar()
        {
            txt_matricula.Clear();
            txt_nome.Clear();
            txt_nota.Clear();
            cbx_sexo.SelectedIndex = -1;
            dtp_data.Text = DateTime.Now.ToString();
            txt_nome.Focus();
            pct_foto.Load("C:/ESCOLA/zico/ico/semFoto.png");
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(dtp_data.Text);
            // manipula data e hora

            foto = foto.Replace(@"\", @"\\");

            sql = string.Format("insert into alunos values(null,'{0}','{1}','{2}','{3}','{4}')"
                ,txt_nome.Text,dt.ToString("yyyy-MM-dd"),cbx_sexo.Text,foto,txt_nota.Text);
            // forma facil de fazer a opção a baixo

            /*sql = "insert into alunos() values(null,'"+txt_nome.Text+"','"+dt.ToString("yyyy-MM-dd")+"','"
                +cbx_sexo.Text+"',"+txt_nota.Text+")";*/

            bd.AlterarTabelas(sql);
            MessageBox.Show("Cadastro do aluno efetuado com sucesso!!!","Cadastro aluno",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listar();
            Limpar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            sql = string.Format("select * from alunos where id = '{0}'", txt_matricula.Text);
            resultado = bd.ConsultarTabelas(sql);

            if(resultado.Rows.Count > 0)
            {
                txt_matricula.Text = resultado.Rows[0]["id"].ToString();
                txt_nome.Text = resultado.Rows[0]["nome"].ToString();
                txt_nota.Text = resultado.Rows[0]["nota"].ToString();
                cbx_sexo.Text = resultado.Rows[0]["sexo"].ToString();
                dtp_data.Text = resultado.Rows[0]["dt_nascimento"].ToString();
                pct_foto.Load(resultado.Rows[0]["foto"].ToString());
            }
            else
            {
                MessageBox.Show("Registro não encontrado. Tente novamente.", "Buscar Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(dtp_data.Text);
            foto = foto.Replace(@"\", @"\\");

            sql = string.Format("update alunos set nome = '{0}', sexo = '{1}', nota = '{2}', dt_nascimento = '{3}', foto = '{4}' where id = '{5}'"
                ,txt_nome.Text,cbx_sexo.Text,txt_nota.Text,dt.ToString("yyyy-MM-dd"),foto,txt_matricula.Text);

            bd.AlterarTabelas(sql);
            MessageBox.Show("Cadastro do aluno atualizado com sucesso!!!", "Cadastro aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
            Limpar();

        } 

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from alunos where id = '{0}'",txt_matricula.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Cadastro do aluno excluido com sucesso!!!", "Cadastro aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
            Limpar();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_menu voltar = new frm_menu();
            voltar.ShowDialog();
        }

        private void frm_aluno_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            foto = "";

            if(ofd_foto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pct_foto.Load(ofd_foto.FileName);
                foto = ofd_foto.FileName;
            }           
       }
    }
}
