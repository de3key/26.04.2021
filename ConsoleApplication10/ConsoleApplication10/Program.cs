using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число йоу");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число йоу");
            int z = Convert.ToInt32(Console.ReadLine());
            int f = (1);
            for (int i = n; i == z; ++i)
            {
                f = f * i;
            }
            Console.Write(f);
            Console.ReadKey();
        }
    }
}


