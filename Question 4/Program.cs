using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter The Length Of The Array.");
            int lth = int.Parse(Console.ReadLine());
            int[] array = new int[lth];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter The Element Of The Array At Index - {i}.");
                array[i] = int.Parse(Console.ReadLine());       
            }
            Console.WriteLine("Enter The Certain Element Of The Array You Want To Check No Of Appearance.");
            int inputC = int.Parse(Console.ReadLine());
            ArrayNumber(array,inputC);
        }
        public static void ArrayNumber(int[] myArray, int userInput)
        {
            for(int i = 0; i < myArray.Length; i++)
            {
                bool isCounted = false;
                for(int c = 0; c < i; c++)
                {
                    if(myArray[i] == myArray[c])
                    {
                        isCounted = true;
                        break;
                    }
                }
                int currentLength = 0;
                if(!isCounted)
                {
                    for(int j = 0; j < myArray.Length; j++)
                    {
                        if(myArray[i] == myArray[j])
                        {
                            currentLength++;
                        }
                    }
                    if(userInput == myArray[i])
                    {
                        Console.WriteLine($"{myArray[i]} occured {currentLength} Time(s).");
                    }
                }
            }
        }
    }
}
