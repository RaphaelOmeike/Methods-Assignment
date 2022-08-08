using System;

namespace Question_6
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
                Console.WriteLine($"Enter The Element Of The Array At Index - {i}.");
                array[i] = int.Parse(Console.ReadLine());       
            }
            Console.WriteLine("Enter The Index Of Certain Element Of The Array You Want To Compare With Neighbours.");
            int inputC = int.Parse(Console.ReadLine());
            GreaterThanNeighbours(array, inputC);
        }
        public static void GreaterThanNeighbours(int[] myArray, int userInput)
        {
            bool result = false;
            for(int j = userInput; j < myArray.Length; j++)
            {
                if(j == 0 && myArray[0] > myArray[j+1])
                {
                    result = true;
                    Console.WriteLine($"The 1st Occurence Of The Element Is At Index - {j}\n{result}.");
                    break;
                }
                else if(j == myArray.Length - 1 && myArray[myArray.Length - 1] > myArray[myArray.Length - 2])
                {
                    result = true;
                    Console.WriteLine($"The 1st Occurence Of The Element Is At Index - {j}\n{result}.");
                    break;
                }
                else
                {
                    if(j > 0 && j < myArray.Length - 1)
                    {
                        if(myArray[j] > myArray[j + 1] && myArray[j] > myArray[j - 1])
                        {
                            result = true;
                            Console.WriteLine($"The 1st Occurence Of The Element Is At Index - {j}\n{result}.");
                            break;
                        }
                    }
                    
                    else{
                        Console.WriteLine($"The 1st Occurence Of The Element Is At Index : -1\n{result}.");
                    }    
                }
            }
        }
    }
}