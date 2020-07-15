using System;
using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public class ReceiptBuilder
    {
        private decimal _amount;
        private Money _tax;
        private Money _total;

        public ReceiptBuilder WithAmount(decimal amount)
        {

            _amount = amount;

            return this;
        }

        
        public Receipt Build()
        {
            Money amount = new Money(_amount);

            _tax = amount.Percentage(20);
            _total = amount.Add(_tax);
            return new Receipt(amount, _tax, _total);
        }

    }

    
}
