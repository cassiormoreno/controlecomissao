using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace controleComissao
{
    public class clsVendedor
    {

        SqlCommand cmd = new SqlCommand(); //Comando para inserir dados na tabela
        StringBuilder sql = new StringBuilder(); //Prepara o texto a ser inserido ou editado
        DataTable dt = new DataTable(); // Tabela de dados, referencia qual tabela vai trazer os dados
        public void salvar(string nome_vendedor, decimal percentual_Comissao, bool situacao) // se colocola ; fala q esta terminando a rotina.
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.stringConexao)) // Faz conexão com o banco de dados
                try
                {
                    conexao.Open(); //Abre a conexao
                    sql.Append("INSERT INTO tbvendedor (nome_vendedor, percentual_comissao, situacao)");
                    sql.Append(" VALUES (@nome_vendedor, @percentual_comissao, @situacao)");
                    cmd.Parameters.Add(new SqlParameter("@nome_vendedor", nome_vendedor));
                    cmd.Parameters.Add(new SqlParameter("@percentual_comissao", percentual_Comissao));
                    cmd.Parameters.Add(new SqlParameter("@situacao", situacao));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery(); // executa na tabela de dados
                }
                catch (Exception erro)
                {
                    throw new Exception(erro.Message); // se ocorrer algum erro ele retorna com o messagebox
                }

                finally // dando certo ou não, o comando finaliza a conexão
                {
                    conexao.Close(); // Fecha a conexão
                    conexao.Dispose(); // Descarrega a conexão da memória
                    cmd.Dispose(); // Descarrega o objeto command da memória
                }
        }

        public void alterar(int codigo, string nome_vendedor, decimal percentual_Comissao, bool situacao) // se colocola ; fala q esta terminando a rotina.
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.stringConexao)) // Faz conexão com o banco de dados
                try
                {
                    conexao.Open(); //Abre a conexao
                    sql.Append("UPDATE tbVendedor"); //Atualize a tabela vendedor
                    sql.Append(" SET nome_vendedor = @nome_vendedor, percentual_comissao = @percentual_comissao, situacao = @situacao"); //Colunas da tabela (nome_vendedor, percental_comissão), recebe o valor informado no formulário
                    sql.Append(" WHERE (codigo = @codigo)"); //Onde o código do vendedor informado for igual ao que estiver na tabela
                    cmd.Parameters.Add(new SqlParameter("@codigo", codigo));
                    cmd.Parameters.Add(new SqlParameter("@nome_vendedor", nome_vendedor));
                    cmd.Parameters.Add(new SqlParameter("percentual_comissao", percentual_Comissao));
                    cmd.Parameters.Add(new SqlParameter("@situacao", situacao));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery(); // executa na tabela de dados
                }
                catch (Exception erro)
                {
                    throw new Exception(erro.Message); // se ocorrer algum erro ele retorna com o messagebox
                }

                finally // dando certo ou não, o comando finaliza a conexão
                {
                    conexao.Close(); // Fecha a conexão
                    conexao.Dispose(); // Descarrega a conexão da memória
                    cmd.Dispose(); // Descarrega o objeto command da memória
                }
        }
        public DataTable pesquisaNome(string nome)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.stringConexao)) // Faz conexão com o banco de dados
                try
                {
                    conexao.Open(); // Abre o banco de dados
                    sql.Append("SELECT * FROM tbVendedor");
                    sql.Append(" WHERE nome_vendedor Like '%' + @nome_vendedor + '%'");
                    sql.Append(" ORDER BY nome_vendedor");
                    cmd.Parameters.Add(new SqlParameter("@nome_vendedor", nome));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
                catch (Exception erro)
                {
                    throw new Exception(erro.Message); // se ocorrer algum erro ele retorna com o messagebox
                }

                finally // dando certo ou não, o comando finaliza a conexão
                {
                    conexao.Close(); // Fecha a conexão
                    conexao.Dispose(); // Descarrega a conexão da memória
                    cmd.Dispose(); // Descarrega o objeto command da memória
                }
        }
    }
}
