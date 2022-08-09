using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Length Of The 1st Array.");
            int lth = int.Parse(Console.ReadLine());
            int[] array = new int[lth];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter The Element Of the 1st Array.");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter The Length Of The 2nd Array.");
            int lth1 = int.Parse(Console.ReadLine());
            int[] array1 = new int[lth1];
            for(int j = 0; j < array1.Length; j++)
            {
                Console.WriteLine("Enter The Element Of the 2nd Array.");
                array1[j] = int.Parse(Console.ReadLine());
            }
            bool result = true;
            if(lth == lth1)
            {
                for(int c = 0; c < array.Length; c++)
                {
                    if(array[c] != array1[c])
                    {
                        result = false;
                        break;
                    }
                }
            }
            Console.WriteLine($"The Result Is {result}.");
        }
    }
}
