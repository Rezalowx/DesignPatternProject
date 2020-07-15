using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    
    
    public class ReceiptRepository : IReceiptRepository
    {
        //private static readonly string databaseName = "myshop";
        //private static readonly string user = "store";
        //private static readonly string pass = "123456";

        private static DbConnection dbConnection;
        public ReceiptRepository()
        {
            dbConnection = DbConnection.Instance();
        }

    public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Receipt receipt)
            {
                if (dbConnection.Connect())
                    {
                        var command = new MySqlCommand("insert into RECEIPT (AMOUNT, TAX, TOTAL)"
                                            + "values(@amount, @tax, @total);", dbConnection.Connection);
                        command.Parameters.AddWithValue("@amount", receipt.Amount.AsDecimal());
                        command.Parameters.AddWithValue("@tax", receipt.Tax.AsDecimal());
                        command.Parameters.AddWithValue("@total", receipt.Total.AsDecimal());
                        command.Prepare();
                        command.ExecuteNonQuery();
                    }
                dbConnection.Close(); 
            }

        public void Update(Receipt receipt)
        {
            throw new NotImplementedException();
        }
    }

    

        //public static void Store(Receipt receipt)
        //{
        //    using (var connection = new MySqlConnection
        //    {
        //        ConnectionString = $"Database={databaseName};Data Source=localhost;User Id={user};Password={pass}"
        //    })
        //    {
        //        connection.Open();
        //        var command = new MySqlCommand("insert into RECEIPT (AMOUNT, TAX, TOTAL)"
        //                + "values(@amount, @tax, @total);", connection);
        //        command.Parameters.AddWithValue("@amount", receipt.Amount.AsDecimal());
        //        command.Parameters.AddWithValue("@tax", receipt.Tax.AsDecimal());
        //        command.Parameters.AddWithValue("@total", receipt.Total.AsDecimal());
        //        command.Prepare();
        //        command.ExecuteNonQuery();
        //    }
        //}

}

