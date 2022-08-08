using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
        // Question 3.
            Console.WriteLine("Enter The Number Of Integers.");
            int lth = int.Parse(Console.ReadLine());
            int[] myArray = new int[lth];
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Enter Integer Number {i + 1}.");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            int swap = 0;
            for(int i = 0; i < myArray.Length; i++)
            {
                for(int j = i + 1; j < myArray.Length; j++)
                {
                    if(myArray[i] < myArray[j])
                    {
                        swap = myArray[j];
                        myArray[j] = myArray[i];
                        myArray[i] = swap;
                    }
                }
            }
            Console.WriteLine($"The Smallest Integer Is, {myArray[myArray.Length - 1]}.");
            Console.WriteLine($"The Largest Integer Is, {myArray[0]}.");
        }
    }
}
