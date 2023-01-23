using System;

namespace GitApplication
{
    class Program
    {
        public static void MatrixA(int h, int w)
        {
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(rnd.Next(0, 2) + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
