using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Home_Work_16
{
    public class TaskThree
    {
        /// <summary>
        /// Имя потока
        /// </summary>
        public string Name => "Task_Three";

        /// <summary>
        /// Метод выводит в консоль значения
        /// </summary>
        public void TaskThreeStart()
        {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Имя: {Name} / Значение {i}");
                    Thread.Sleep(3000);
                }
                Console.WriteLine($"\nПоток {Name} завершил свою работу");
        }
    }
}
