using System;
using System.Collections.Generic;

namespace Тумаков
{
    
   
    internal class Program
    {
        static void Main()
        {
            //============================  Упражнение 9.1 ===============================
            Console.WriteLine("Упражнение 9.1\n");
            
            //Ниже приведены примеры заполнения полей с помощью конструкторов

            Bank_Shet shet_0 = new Bank_Shet();
            Console.WriteLine($"Номер счёта : {shet_0.Number}\n");

            Bank_Shet shet_1 = new Bank_Shet(1000.00);
            Console.WriteLine($"Номер счёта : {shet_1.Number}");
            Console.WriteLine($"Баланс : {shet_1.Balance}\n"); ;

            Bank_Shet shet_2 = new Bank_Shet(TypeBankShet.Saving);
            Console.WriteLine($"Номер счёта : {shet_2.Number}");
            Console.WriteLine($"Тип счёта : {shet_2.Type}\n");

            Bank_Shet shet_3 = new Bank_Shet(1000000.00, TypeBankShet.Credit);
            Console.WriteLine($"Номер счёта : {shet_3.Number}");
            Console.WriteLine($"Баланс : {shet_3.Balance}");
            Console.WriteLine($"Тип счёта : {shet_3.Type}\n");

            //============================  Упражнение 9.2 ===============================
            Console.WriteLine("Упражнение 9.2\n");

            Bank_Shet shet_4 = new Bank_Shet(1000000);
            Console.WriteLine($"Номер счёта : {shet_4.Number}");
            Console.WriteLine($"Баланс : {shet_4.Balance}\n"); ;

            shet_4.PlusMoney(10000.00);
            shet_4.PlusMoney(11678.00);
            shet_4.MinusMoney(9.00);
            shet_4.MinusMoney(567.00);
            

            List<BankTransaction> bankTransactions = shet_4.All_Transactions();

            foreach (BankTransaction bankTransaction in bankTransactions)
            {
                Console.WriteLine($"Дата транзакции : {bankTransaction.Transaction_Date}, сумма операции : {bankTransaction.Sum}");
            }

        }
    }
}
