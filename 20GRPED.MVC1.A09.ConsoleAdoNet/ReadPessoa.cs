using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace _20GRPED.MVC1.A09.ConsoleAdoNet
{
    public class ReadPessoa
    {
        public void Execute()
        {
            Console.WriteLine();
            Console.WriteLine("======================");
            Console.WriteLine("Dados da tabela Pessoa");

            var connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\felipe.andrade\source\repos\20GRPED.MVC1.A09.ConsoleAdoNet\20GRPED.MVC1.A09.ConsoleAdoNet\App_data\ConsoleAdoNet.mdf;Integrated Security=True";

            var cmdText = $"SELECT Nome, ID FROM Pessoa";

            using (var sqlConnection = new SqlConnection(connectionString)) //já faz o close e dispose
            using (var sqlCommand = new SqlCommand(cmdText, sqlConnection)) //já faz o close
            {
                sqlCommand.CommandType = CommandType.Text;

                sqlConnection.Open();

                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        var idColumnIndex = reader.GetOrdinal("ID");
                        var nomeColumnIndex = reader.GetOrdinal("Nome");
                        while (reader.Read())
                        {
                            var id = reader.GetFieldValue<int>(idColumnIndex);
                            var nome = reader.GetFieldValue<string>(nomeColumnIndex);

                            Console.WriteLine($"ID: {id}, Nome: {nome}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Rows!");
                    }
                }
            }
        }
    }
}
