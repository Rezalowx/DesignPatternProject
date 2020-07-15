﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    public class Receipt
    {
        public Money Amount { get; set; }
        public Money Tax { get; set; }
        public Money Total { get; set; }

        public Receipt(Money amount, Money tax, Money total)
        {
            Amount = amount;
            Tax = tax;
            Total = total;
        }
        public IEnumerable<string> Format()
        {
            return new List<string>() { //
                    "Receipt", //
                    "=======", //
                    "Item 1 ... " + Amount.Format(), //
                    "Tax    ... " + Tax.Format(), //
                    "----------------", //
                    "Total  ... " + Total.Format() //
            };
        }

        //public Receipt CreateReceipt(Money amount)
        //{


        //    ReceiptBuilder receiptBuilder = new ReceiptBuilder();

        //    Receipt receipt =
        //            receiptBuilder
        //                .WithAmount(amount)
        //                .Build();

        //    //ReceiptRepository.Update(receipt);

        //    return receipt;
        //}

     
            
    }
}
