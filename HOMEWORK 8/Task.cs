using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HOMEWORK_8
{
    internal class Task
    {
        public string Viev_task { get; }  
        public DateTime Deadline { get;}  
        public string Client {  get; } 
        public Employee Performer { get; set; }   
        public Task_status Status { get; set; } 

        public List<Report> Reports { get; }
        
        public Task (string viev_task, DateTime deadline, string client, Employee performer, Task_status status)
        {
            Viev_task = viev_task;
            Deadline = deadline;    
            Client = client;    
            Performer = performer;
            Status = status;
            Reports = new List<Report>();
        }
        /// <summary>
        /// Метод, меняющий статус задачи на "Выполнена".
        /// </summary>
        private void Do_Status_Completed()
        {
            if (Status == Task_status.Checking)
            {
                Status = Task_status.Completed;
            }
        }

        /// <summary>
        /// Метод, чтобы исполнитель взял задачу в работу
        /// </summary>
        /// <param name="task"></param>
        public void Take_Task(Employee performer, Task task)
        {
            performer.AddTask(task);
            task.Status = Task_status.Processing;
        }

        /// <summary>
        /// Метод, чтобы исполнитель делегировал задачу другому исполнителю
        /// </summary>
        /// <param name="task"></param>
        public void Delegate_Task(Employee performer_0, Employee performer, Task task)
        {
            performer_0.RemoveTask();
            performer.AddTask(task);
            task.Status = Task_status.Giving;
        }

        /// <summary>
        /// Метод, чтобы исполнитель отказался от задачи
        /// </summary>
        /// <param name="task"></param>
        public void Decline_Task()
        {
            Employee performer = null;
        }

        
        
        /// <summary>
        /// Метод, меняющий статус задачи на Выполненную после составления отчёта по ней
        /// </summary>
        /// <param name="report"></param>
        public void Complete_Task(string report)
        {
            Status = Task_status.Completed;
        }



    }
}
