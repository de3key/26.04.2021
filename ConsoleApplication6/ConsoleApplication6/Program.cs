using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    enum Eactive
    {
        STOP = 0, LEFT, RIGHT, UP, DOWN
    };
    class Progam
    {
        static int[] tailX = new int[360];
        static int[] tailY = new int[360];
        static int ntail;
        static bool gameOver;
        const int width = 20;
        const int height = 20;
        static int x, y, fruitX, FruitY;
        static int score;

        static Eactive dir;
        static void setup()
        {
            Random rand = new Random();
            int marvel = rand.Next();

            gameOver = false;
            dir = Eactive.STOP;
            x = width / 2;
            y = height / 2;
            fruitX = marvel % (width - 2);
            FruitY = marvel % (height - 2);
            score = 0;
        }
        static void draw()
        {
            Console.Clear();
            for (int i = 0; i <= width; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("#");
            }
            Console.WriteLine();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 0 || j == (width - 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("#");
                    }
                    else
                    {
                        bool print = false;
                        for (int k = 0; k < ntail; k++)
                        {
                            if (tailX[k] == j && tailY[k] == i)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("o");
                                print = true;
                            }
                        }
                        if (!print)
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i<)
                               
            Console.WriteLine("you won!");
        }
    }
}   


        




