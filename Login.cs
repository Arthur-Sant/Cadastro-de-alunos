using MySql.Data.MySqlClient;
using System.Data;

namespace cad_alunos_04_2d2
{
    class Login
    {
        //variavel estatio -> unica classe
        // para armanezar o nome e o tipo de ususario
        private static string nome;

        //metodo para validarr o usuario
        public bool validarUsuario(string usuario, string senha)
        {
            //instancia da classe de conexao com o banco de dados
            ConexaoBd bd = new ConexaoBd();
            string sql = string.Format("select * from usuario where email = '{0}' and senha = '{1}'",usuario,senha);
            DataTable dt = new DataTable();
            dt = bd.ConsultarTabelas(sql);

            //testar se retornou valores
            if(dt.Rows.Count > 0)
            {
                nome = dt.Rows[0]["nome"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        //metodo para retornar o nome do usuario
        public string usuarioLogado()
        {
            return nome;

        }
    }
}
