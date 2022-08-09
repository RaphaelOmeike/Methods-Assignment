using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Length Of The 1st Array.");
            int lth = int.Parse(Console.ReadLine());
            char[] array = new char[lth];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter The Character Of the 1st Array.");
                array[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter The Length Of The 2nd Array.");
            int lth1 = int.Parse(Console.ReadLine());
            char[] array1 = new char[lth1];
            for(int j = 0; j < array1.Length; j++)
            {
                Console.WriteLine("Enter The Character Of the 2nd Array.");
                array1[j] = char.Parse(Console.ReadLine());
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
