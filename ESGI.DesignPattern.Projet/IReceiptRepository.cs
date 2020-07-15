using System;
using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public interface IReceiptRepository
    {
        void Insert(Receipt receipt);
        void Update(Receipt receipt);
        void Delete(int id);
    }
}
