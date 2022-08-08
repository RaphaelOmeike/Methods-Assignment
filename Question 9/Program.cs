using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter The Length Of The Array.");
            int lth = int.Parse(Console.ReadLine());
            int[] myArray = new int[lth];
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Enter The Element Of The Array At Index - {i}.");
                myArray[i] = int.Parse(Console.ReadLine());       
            }
            Sorting(myArray);
        }
        public static void Sorting(int[] array)
        {
            int swapI;
            
            for(int i = 0; i <= array.Length - 1; i++)
            {
                for(int j = i + 1; j <= array.Length - 1; j++)
                {
                    if(array[i] < array[j])
                    {
                        swapI = array[i];
                        array[i] = array[j];
                        array[j] = swapI;
                    }
                }
            }
            Console.WriteLine($"The Largest Number Is, {array[0]},");
            Console.WriteLine("Descending Order.");
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
