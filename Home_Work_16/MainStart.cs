using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_16
{
    /// <summary>
    /// Логика метода Main
    /// </summary>
    public class MainStart
    {
        /// <summary>
        /// Метод запускает все ассинхронные методы
        /// </summary>
        /// <param name="TOne"></param>
        /// <param name="TTwo"></param>
        /// <param name="TThree"></param>
        public async void Start(TaskOne TOne, TaskTwo TTwo, TaskThree TThree)
        {
            Task t1 = Task.Run(() => TOne.TaskOneStart());
            Task t2 = Task.Run(() => TTwo.TaskTwoStart());
            Task t3 = Task.Run(() => TThree.TaskThreeStart());
            await Task.WhenAll(new[] { t1, t2, t3 }); // Задачи в параметрах будут выполняться параллельно

            // Эта задача ждёт завершения предыдущей
            await Task.Run(() =>
            {
               Console.WriteLine("\nВсе потоки завершили свою работу.\n" +
                    "Для завершения нажмите любую клавишу...");
               Console.ReadKey();
            });
        }
    }
}
