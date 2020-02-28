using System;
using System.Data;
using System.Data.SqlClient;

namespace _20GRPED.MVC1.A09.ConsoleAdoNet
{
    public class InsertPessoa
    {
        public void Execute()
        {
            Console.Write("Entre com o nome: ");
            var input = Console.ReadLine();

            var connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\felipe.andrade\source\repos\20GRPED.MVC1.A09.ConsoleAdoNet\20GRPED.MVC1.A09.ConsoleAdoNet\App_data\ConsoleAdoNet.mdf;Integrated Security=True";

            var cmdText = "INSERT INTO Pessoa" +
                "		(Nome)" +
                "VALUES	(@pessoaNome);";

            using (var sqlConnection = new SqlConnection(connectionString)) //já faz o close e dispose
            using (var sqlCommand = new SqlCommand(cmdText, sqlConnection)) //já faz o close
            {
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters
                    .Add("@pessoaNome", SqlDbType.VarChar).Value = input;

                sqlConnection.Open();

                var resutScalar = sqlCommand.ExecuteScalar();
            }
        }
    }
}
