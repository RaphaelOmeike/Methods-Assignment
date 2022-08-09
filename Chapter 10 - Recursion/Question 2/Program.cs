using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number,N");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Number,K");
            int k1 = int.Parse(Console.ReadLine());
            PrintSequence(n1,k1);
        }
        static void PrintSequence(int n, int t)
        {
            if(n < 1)
            {
                return;
            }
            for(int i = 1; i <= t; i++)
            {
                Console.WriteLine(t-(n-1) + "," + i);
            }
            PrintSequence(n-1,t - 1);
        }
    }
}
