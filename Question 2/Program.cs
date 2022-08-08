using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
        // Question 2.
            Console.WriteLine("Enter The Number.");
            int inputN = int.Parse(Console.ReadLine());
            for(int i = 0; i <= inputN; i++)
            {
                if(i % 3 == 0 && i % 7 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }
    }
}
