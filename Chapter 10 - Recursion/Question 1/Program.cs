using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number,N");
            int n = int.Parse(Console.ReadLine());
            Loops(n - 1);
        }
        public static void Loops(int k)
        {
            for(int i = 1; i <= k; i++)
            {
                Loops(k - 1);
            }
            if(k < 0)
            {
                return;
            }
        }
    }
}
