using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Тумаков
{
    enum TypeBankShet
    {
        Saving,
        Current,
        Credit
    }
    internal class Bank_Shet
    {
        private static int newNumber = 0;
        public int Number { get; }
        public double Balance { get; set; }
        public TypeBankShet Type { get; set; }

        //Закрытое поле класса
        private readonly Queue<BankTransaction> queue = new Queue<BankTransaction>();

        /// <summary>
        /// Метод, который увеличивает значение статистической переменной
        /// </summary>
        /// <returns></returns>
        public static int GenerateNumber()
        {
            int number = newNumber++;
            return number;
        }

        /// <summary>
        /// Метод для печати данных Счёта в консоль
        /// </summary>
        public void PrintShet()
        {
            Console.WriteLine($"Номер аккаунта: {Number}");
            Console.WriteLine($"Баланс: {Balance}");
            Console.WriteLine($"Тип банковского счёта: {Type}\n");
        }

        /// <summary>
        /// Метод, который переводит деньги с одного счёта на другой
        /// </summary>
        /// <param name="shet"></param>
        /// <param name="money"></param>
        public void TransferMoney(ref Bank_Shet shet_1, double money)
        {
            if (Balance <= money)
            {
                shet_1.Balance -= money;
                Balance += money;

            }
            else { Console.WriteLine("Недостаточно средств для перевода"); }
        }

        // ============================================================= ВОТ ЗДЕСЬ НАЧИНАЕТСЯ ДОМАШНЯЯ РАБОТА НА ЭТОТ УРОК !!! ============================================================================

        // !!!!!===============  КОНСТРУКТОРЫ ДЛЯ УПРАЖНЕНИЯ 9.1 ===============!!!!!

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Bank_Shet()
        {
            Number = GenerateNumber();
        }

        /// <summary>
        /// Конструктор заполнения поля Баланс
        /// </summary>
        /// <param name="balance"></param>
        public Bank_Shet(double balance)
        {
            Balance = balance;
            Number = GenerateNumber();
        }

        /// <summary>
        /// Конструктор заполнения поля Тип банковского счёта
        /// </summary>
        /// <param name="type"></param>
        public Bank_Shet(TypeBankShet type)
        {
            Type = type;
            Number = GenerateNumber();
        }

        /// <summary>
        /// Конструктор заполнения поля Баланса и Типа банковского счёта
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="type"></param>
        public Bank_Shet(double balance, TypeBankShet type)
        {
            Type = type;
            Balance = balance;
            Number = GenerateNumber();
        }

        //============================= МЕТОДЫ ДЛЯ УПРАЖНЕНИЯ 9.2 ==============================

        /// <summary>
        /// Метод для внесения денег Ha счёт
        /// </summary>
        /// <param name="money"></param>
        public void PlusMoney(double money)
        {
            if (money > 0)
            {
                Balance += money;
                Console.WriteLine($"На ваш счёт успешно начислено {money} рублей, остаток {Balance} рублей");
                queue.Enqueue(new BankTransaction(+money));
            }
            else
                Console.WriteLine("Введите положительную сумму денег");

        }

        /// <summary>
        /// Метод для снятия денег со счёта
        /// </summary>
        /// <param name="money"></param>
        public void MinusMoney(double money)
        {
            if (money <= Balance)
            {
                Balance -= money;
                Console.WriteLine($"С вашего счёта успешно снято {money} рублей, остаток {Balance} рублей");
                queue.Enqueue(new BankTransaction(-money));
            }
            else
            {
                Console.WriteLine("Недостаточно средств для снятия данной суммы\n");
            }
        }

        /// <summary>
        /// Метод, показывающий список всех транзакций
        /// </summary>
        /// <returns></returns>
        public List<BankTransaction> All_Transactions()
        {
            return queue.ToList();
        }

        //============================= МЕТОД ДЛЯ УПРАЖНЕНИЯ 9.3 ==============================

        /// <summary>
        /// Mетoд, который данные o проводках из очереди запишет в файл.
        /// </summary>
        /// <param name="queue"></param>
        public void Dispose()
        {
            string file_name = "All_transactions.txt";
            foreach (BankTransaction transaction in queue)
            {

                File.WriteAllText(file_name, transaction.ToString());

            }
            queue.Clear();

            GC.SuppressFinalize(this);
        }
    }
}
