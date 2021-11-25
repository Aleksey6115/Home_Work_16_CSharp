using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Home_Work_16
{
    public class TaskOne
    {
        /// <summary>
        /// Имя потока
        /// </summary>
        public string Name => "Task_One";

        /// <summary>
        /// Метод выводит в консоль значения
        /// </summary>
        public void TaskOneStart()
        {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Имя: {Name} / Значение {i}");
                    Thread.Sleep(1000);
                }
                Console.WriteLine($"\nПоток {Name} завершил свою работу");
        }
    }
}
