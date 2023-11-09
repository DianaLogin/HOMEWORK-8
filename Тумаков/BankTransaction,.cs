using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    internal class BankTransaction
    {
        //Поля класса только для чтения (readonly)
        public readonly DateTime Transaction_Date;
        public readonly double Sum;


        public BankTransaction(double sum)
        {
            Transaction_Date = DateTime.Now;
            Sum = sum;
        }

    }
}
