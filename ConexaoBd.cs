using MySql.Data.MySqlClient; 
using System.Data;

namespace cad_alunos_04_2d2
{
    class ConexaoBd //para alguns comandos de MySql e preciso baixar uma extensão do MySql
    {
        private MySqlConnection conexao; // variavel de conexão do c# com MySql

        public void ConectarBD()
        {
            conexao = new MySqlConnection("persist security info = false;server=localhost;database=cadastro_aluno2d2;uid=root;pwd=;");
            conexao.Open();
            /*persist security info = false; faz com que não passe informações do banco quando tiver executando,
             então nao consegue ser hackeado
              */
        }

        public void AlterarTabelas(string sql)
        {
            ConectarBD();
            MySqlCommand comandos = new MySqlCommand(sql,conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
        }

        public DataTable ConsultarTabelas(string sql)
        {
            ConectarBD();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexao.Close();
            return resultado;
        }
    }
}
