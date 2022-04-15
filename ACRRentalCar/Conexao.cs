using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// definição dos namespaces usados no projeto para o sql server

using System.Data;
using System.Data.SqlClient;

namespace ACRRentalCar
{
    public class Conexao
    {
        //metodo para realizar a conexao com o banco de dados

        public static SqlConnection getConnection()
        {
            // cria um objeto (varíavel cnn) do tipo SqlConnection 
            // e configura a string de conexão 
            SqlConnection cnn = new SqlConnection(@"Data Source=EXALTARE;Initial Catalog=DB_RENTALCAR;Integrated Security=True;Pooling=False");
            return cnn;
        }

    }
}
