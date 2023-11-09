using System;


namespace HOMEWORK_8
{
    internal class Employee
    {
        public string Name { get;}
        public Employee_status Status { get;}

        public Task Task { get; set; }

        /// <summary>
        /// Конструктор класса Employee
        /// </summary>
        /// <param name="name"></param>
        /// <param name="status"></param>
        public Employee(string name, Employee_status status)
        {
            Name = name;
            Status = status;
        }

        /// <summary>
        /// Метод, добавляющий задачу работнику
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(Task task)
        {
            Task = task;
        }

        /// <summary>
        /// Метод, удаляющий задачу работника
        /// </summary>
        /// <param name="task"></param>
        public void RemoveTask()
        {
            Task = null;
        }
    }
}
