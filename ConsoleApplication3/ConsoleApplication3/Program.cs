using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.14 B
            Console.WriteLine("Напишите свое число СЭР");
            double a = Convert.ToDouble(Console.ReadLine());
            double a2 = Math.Pow(a, 2);
            Console.WriteLine("Решебник Котельникова. ответ:" + a2);

            Console.ReadKey();

            //1.14 ж
            Console.WriteLine("Напишите свое число СЭР");
            double a= Convert.ToDouble(Console.ReadLine());
            double a2= Math.Pow(a, 2);
            Console.WriteLine("Решебник Котельникова. ответ:" + a2);
            Console.ReadKey();

               
        }
    }
}
