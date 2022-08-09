using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Length Of The Array.");
            int lth = int.Parse(Console.ReadLine());
            int[] array = new int[lth];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter The Element Of The  Array.");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
