using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Reqem Daxil et:");
                int reqem = int.Parse(Console.ReadLine());

                Lab[] labs = new Lab[reqem];

                for (int i = 0; i < reqem; i++)
                {
                    labs[i] = new Lab(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
                }
                foreach (Lab item in labs)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }
        }
    }
}
