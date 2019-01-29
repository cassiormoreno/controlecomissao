using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleComissao
{
    public class clsConexao
    {
        private static string conexao = @"Data Source=.\SQLEXPRESS; Initial Catalog=bdComissao; User id=sa; Password=sa"; 
        //private static string conexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=bdComissao;Integrated Security=True";


        public static string stringConexao
        {
        get
            {
                return conexao;
            }

        }

    }
}
