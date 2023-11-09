using System;
using System.Collections.Generic;

namespace HOMEWORK_8
{
    internal class Project
    {
        // Свойства класса Проект
        public string Viev { get; }
        public DateTime Deadline { get;}
        public string Client { get; }
        public Employee Teamlead { get; }
        public List<Task> Tasks { get; set; }
        public Project_status Status { get; set; }

        
        /// <summary>
        /// Конструктор класса Проект
        /// </summary>
        /// <param name="deadline"></param>
        public Project(string viev, DateTime deadline, string client, Employee teamlead)
        {
            Viev = viev;
            Deadline = deadline;
            Client = client;
            Teamlead = teamlead;
            Tasks = new List<Task>();
            Status = Project_status.Project;
        }


        /// <summary>
        /// Метод добавления задачи в список задач проекта
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(Task task)
        {
            if (Project_status.Project == Status)
            {
                Tasks.Add(task);
            }
            else
            {
                Console.WriteLine("Невозможно добавить новую задачу в список задач в текущем состоянии проекта");
            }
        }

        /// <summary>
        /// Метод удаления задачи из списка задач проекта
        /// </summary>
        public void RemoveTask(Task task)
        {
            Tasks.Remove(task);
        }


        /// <summary>
        /// Метод-проверка : выполнены ли все задачи проекта.
        /// Значит, что проект закрытый
        /// </summary>
        /// <returns></returns>
        public bool Project_Closed()
        {
            foreach (Task task in Tasks)
            {
                if (Task_status.Completed != task.Status)
                {
                    return false;
                }
            }
            return true;
        }

       
        /// <summary>
        /// Метод меняет статус проекта на "Исполнение"
        /// </summary>
        public void Doing_Project()
        {
            foreach (Task task in Tasks)//если всевозможные задачи назначены,
                                        //то проект переходит в статус "Исполнение"
            {
                if (Task_status.Giving == task.Status) 
                {
                    Status = Project_status.Doing;
                }
            }
        }

        /// <summary>
        /// Метод меняет статус проекта на "законченный"
        /// </summary>
        public void CloseProject()
        {
            Status = Project_status.Closed;
        }
        

        /// <summary>
        /// Метод, позволяющий создавать задачи только в статусе проекта "Проект"
        /// </summary>
        /// <param name="status"></param>
        public void Create_Task(Project_status status, Task task)
        {
            if (status == Project_status.Project)
            {
                Tasks.Add(task);
            }
            else
            { Console.WriteLine("Невозможно добавить новую задачу в данном статусе проекта"); }
        }

        /// <summary>
        /// Метод проверки отчётов
        /// </summary>
        public void Check_Reports()
        {
            bool all_Tasks_Completed = true;

            foreach (Task task in Tasks)
            {
                if (task.Status != Task_status.Completed)
                {
                    all_Tasks_Completed = false;
                    break;
                }
            }

            if (all_Tasks_Completed)
            {
                Console.WriteLine("Все задачи верно выполнены. Утвердить отчёт.");
            }
            else
            {
                Console.WriteLine("Не все задачи выполнены корректно. Отправить отчёт на доработку.");
            }
        }
    }
}

