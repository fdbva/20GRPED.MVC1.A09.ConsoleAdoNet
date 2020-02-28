using System;
using System.Data;
using System.Data.SqlClient;

namespace _20GRPED.MVC1.A09.ConsoleAdoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var insertPessoa = new InsertPessoa();
            insertPessoa.Execute();

            var readPessoa = new ReadPessoa();
            readPessoa.Execute();
        }
    }
}
