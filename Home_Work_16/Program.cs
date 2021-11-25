using System;
using System.Threading.Tasks;
using System.Threading;

namespace Home_Work_16
{
    class Program
    {
        static void Main(string[] args)
        {
            MainStart MS = new MainStart();
            MS.Start(new TaskOne(), new TaskTwo(), new TaskThree());

            Console.ReadKey();
        }
    }
}
