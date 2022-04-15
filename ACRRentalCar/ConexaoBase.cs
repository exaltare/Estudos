namespace ACRRentalCar
{
    public class ConexaoBase
    {
        //metodo para realizar a conexao com o banco de dados

        public static SqlConnection GetConnection()
        {
            //cria um objeto (variavel cnn) do tipo SqlConnection
            //e configura a string de conexao
            SqlConnection cnn = new SqlConnection(@"Data Source=EXALTARE;Initial Catalog=DB_RENTALCAR;Integrated Security=True;Pooling=False");
            return cnn;
        }
    }
}