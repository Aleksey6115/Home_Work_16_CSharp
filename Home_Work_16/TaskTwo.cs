using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Home_Work_16
{
    public class TaskTwo
    {
        /// <summary>
        /// Имя потока
        /// </summary>
        public string Name => "Task_Two";

        /// <summary>
        /// Метод выводит в консоль значения
        /// </summary>
        public void TaskTwoStart()
        {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Имя: {Name} / Значение {i}");
                    Thread.Sleep(2000);
                }
                Console.WriteLine($"\nПоток {Name} завершил свою работу");
        }

    }
}
