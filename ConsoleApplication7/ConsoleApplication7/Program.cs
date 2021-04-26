using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Здраствуйте, я голосовой помощник Алиса.");
            Console.WriteLine("Введите ваше число сеньор.");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Перевод в систему вычесления Байт, и тд.");
            string z = Convert.ToString(Console.ReadLine());
            if (z == "Байты")
            {
                double y1 = y / 8;
                Console.WriteLine("Ответ" + y1);
            }
            else if (z == "Кб")
            {
                double y2 = y/8/1024;
                Console.WriteLine("Ответ" + y2);
            }
            Console.ReadKey();



        }
    }
}
