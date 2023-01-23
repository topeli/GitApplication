using System;

namespace GitApplication
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
        }
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
        public static void MatrixB(int h, int w)
        {
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(rnd.Next(0, 2) + " ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintMyName()
        {
            Console.WriteLine("Antonyan Masha");
            Console.WriteLine("10.3");
            Console.WriteLine("Janyary 23");
        }
        public void PrintMyName()
        {
            Console.WriteLine("Antonina Lazarenko");
            Console.WriteLine("10.3");
            Console.WriteLine("19, March");
        }
        public static void PrintMyName()
        {
            Console.WriteLine("Завьялова Арина Алексеевна");
            Console.WriteLine("10.3");
            Console.WriteLine("21.10.2006");
        }
    }
}