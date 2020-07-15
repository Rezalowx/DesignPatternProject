using System;
using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public class ReceiptBuilder
    {
        private Money _amount;
        private Money _tax;
        private Money _total;

        public ReceiptBuilder WithAmount(decimal amount)
        {
            _amount = new Money(amount);
            return this;
        }
        public ReceiptBuilder WithTax(int tax)
        {

            _tax = _amount.Percentage(tax);
            return this;
        }


        public Receipt Build()
        {

            _total = _amount.Add(_tax);
            return new Receipt(_amount, _tax, _total);
        }

    }

    
}
