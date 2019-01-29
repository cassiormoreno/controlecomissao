using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleComissao
{
    public class clsComissao
    {
        SqlCommand cmd = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable dt = new DataTable();

        public void inserir(int codigoVendedor, DateTime data, decimal valor, decimal totalComissao)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.stringConexao))
                try
                {
                    conexao.Open();
                    sql.Append("INSERT INTO tbComissao (codigo_Vendedor, data, valor, total_Comissao)");
                    sql.Append(" VALUES (@codigo_Vendedor, @data, @valor, @total_Comissao)");
                    cmd.Parameters.Add(new SqlParameter("@codigo_Vendedor", codigoVendedor));
                    cmd.Parameters.Add(new SqlParameter("@data", data));
                    cmd.Parameters.Add(new SqlParameter("@valor", valor));
                    cmd.Parameters.Add(new SqlParameter("@total_Comissao", totalComissao));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    throw new Exception(erro.Message);
                }
        }

        public void alterar(int codigoVendedor, DateTime data, decimal valor, decimal totalComissao, int idLancamento)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.stringConexao))
            {
                try
                {
                    conexao.Open();
                    sql.Append("update tbComissao");
                    sql.Append("set codigo_Vendedor = @codigoVendedor, DATA = @data , valor = @valor ,total_Comissao = @totalComissao");
                    sql.Append("where lancamento = @idLancamento");
                    cmd.Parameters.Add(new SqlParameter("@codigo_Vendedor", codigoVendedor));
                    cmd.Parameters.Add(new SqlParameter("@DATA", data));
                    cmd.Parameters.Add(new SqlParameter("@valor", valor));
                    cmd.Parameters.Add(new SqlParameter("@total_Comissao", totalComissao));
                    cmd.Parameters.Add(new SqlParameter("@lancamento", idLancamento));
                    cmd.CommandText = sql.ToString();
                    cmd.Connection = conexao;
                    cmd.ExecuteNonQuery(); // executa na tabela de dados
                }
                catch (Exception erro)
                {

                    throw new Exception(erro.Message);
                }
                finally {
                    conexao.Close(); // Fecha a conexão
                    conexao.Dispose(); // Descarrega a conexão da memória
                    cmd.Dispose(); // Descarrega o objeto command da memória
                }
            }
        }

        public DataTable pesquisaComissao(string nome)
        {
            using (SqlConnection conexao = new SqlConnection(clsConexao.stringConexao)) // Faz conexão com o banco de dados
                try
                {
                    conexao.Open(); // Abre o banco de dados
                    sql.Append("select lancamento, codigo_Vendedor,DATA,valor, total_Comissao from  tbComissao");
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
