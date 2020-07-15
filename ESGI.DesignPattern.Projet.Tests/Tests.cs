using System;
using Moq;
using System.Diagnostics;
using Xunit;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class Tests
    {
        [Fact]
        public void CreateReceiptTest()
        {
          
            ReceiptBuilder receiptBuilder = new ReceiptBuilder();

            Receipt receipt =
                    receiptBuilder
                        .WithAmount(10)
                        .WithTax(20)
                        .Build();


            var dumpOutput = "Receipt=======Item 1 ... 10,00Tax    ... 2,00----------------Total  ... 12,00";

            string test = "";
            foreach(string value in receipt.Format())
            {
                test += value;
            }

            Assert.Equal(dumpOutput, test);

        }
        
        [Fact]
        public void DbConnectionTest()
        {
            Mock<iDbConnection> mockdbConnection = new Mock<iDbConnection>();
            mockdbConnection.Setup(x => x.Connect());
            
        }
}
}

