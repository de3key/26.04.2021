using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ниггерс сникерс");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число ниггерс сникерс");
            int b = Convert.ToInt32(Console.ReadLine());
            int s = (0);
            for (int i = a; i <= b; i++)
            {
                s = s + i * i;
            }
            Console.Write(s);
            Console.ReadKey();
        }
    }
}
