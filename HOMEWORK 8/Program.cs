using System;



namespace HOMEWORK_8
{
    enum Employee_status
    {
        TeamLead,
        Senior,
        Middle,
        Junior
    }

    enum Project_status
    {
        Project,
        Doing,
        Closed
    }

    enum Task_status
    {
        Giving,
        Processing,
        Checking,
        Completed
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Diana = new Employee("Диана", Employee_status.TeamLead);          //=================
            Employee Ilya = new Employee("Илья", Employee_status.Senior);              //
            Employee Amir = new Employee("Амир", Employee_status.Middle);              // Создала 10 человек 
            Employee Egor = new Employee("Егор", Employee_status.Middle);              //     команды
            Employee Gulnaz = new Employee("Гульназ", Employee_status.Middle);         //
            Employee Dasha = new Employee("Даша", Employee_status.Junior);             //==================
            Employee Nastya = new Employee("Настя", Employee_status.Junior);
            Employee Liza = new Employee("Лиза", Employee_status.Junior);
            Employee Daniil = new Employee("Даниил", Employee_status.Junior);
            Employee Vlad = new Employee("Влад", Employee_status.Junior);


            Project project = new Project("Написать крутые программы по проге", new DateTime(2024, 01, 01), "КФУ", Diana); // Создала проект

            Task task1 = new Task("Выполнить ДЗ 1", new DateTime(2024, 01, 01), "КФУ", Vlad, Task_status.Giving);      //================
            Task task2 = new Task("Выполнить ДЗ 2", new DateTime(2024, 01, 01), "КФУ", Daniil, Task_status.Giving);    //    Раздала
            Task task3 = new Task("Выполнить ДЗ 3", new DateTime(2024, 01, 01), "КФУ", Liza, Task_status.Giving);      //     задачи
            Task task4 = new Task("Выполнить ДЗ 4", new DateTime(2024, 01, 01), "КФУ", Nastya, Task_status.Giving);    //   сотрудникам
            Task task5 = new Task("Выполнить ДЗ 5", new DateTime(2024, 01, 01), "КФУ", Dasha, Task_status.Giving);     //================
            Task task6 = new Task("Выполнить ДЗ 6", new DateTime(2024, 01, 01), "КФУ", Gulnaz, Task_status.Giving);    
            Task task7 = new Task("Выполнить ДЗ 7", new DateTime(2024, 01, 01), "КФУ", Egor, Task_status.Giving);      
            Task task8 = new Task("Выполнить ДЗ 8", new DateTime(2024, 01, 01), "КФУ", Amir, Task_status.Giving);
            Task task9 = new Task("Выполнить ДЗ 9", new DateTime(2024, 01, 01), "КФУ", Ilya, Task_status.Giving);
            Task task10 = new Task("Раздать задачи работникам", new DateTime(2023, 12, 01), "КФУ", Diana, Task_status.Giving);

            Vlad.AddTask(task1);
            Daniil.AddTask(task2);
            Liza.AddTask(task3);
            Nastya.AddTask(task4);
            Dasha.AddTask(task5);
            Gulnaz.AddTask(task6);
            Egor.AddTask(task7);
            Amir.AddTask(task8);
            Ilya.AddTask(task9);
            Diana.AddTask(task10);
        }
    }
}

