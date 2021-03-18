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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        Login objlogin = new Login();

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(objlogin.validarUsuario(txt_email.Text,txt_senha.Text)) {
                txt_senha.Clear();
                txt_email.Clear();
                this.Visible = false;
                frm_aluno aluno = new frm_aluno();
                aluno.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido...","Error Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            txt_senha.Clear();
            txt_email.Clear();
            this.Visible = false;
            cad_usuario cadastro = new cad_usuario();
            cadastro.ShowDialog();
            this.Visible = true;

        }
    }
}
