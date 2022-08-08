using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
        // Chapter 9 :- Methods.
        // Question 3.
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter The Number.");
            int input = int.Parse(Console.ReadLine());        
            int b = input % 10;
            LastNumber(b);
        }
        public static void LastNumber(int a)
        {
            switch(a)
            {
                case 0:
                Console.WriteLine($"The Last Digit Is Zero(0).");
                break;
                case 1:
                Console.WriteLine($"The Last Digit Is One(1).");
                break;
                case 2: 
                Console.WriteLine($"The Last Digit Is Two(2).");
                break;
                case 3:
                Console.WriteLine($"The Last Digit Is Three(3).");
                break;
                case 4:
                Console.WriteLine($"The Last Digit Is Four(4).");
                break;
                case 5:
                Console.WriteLine($"The Last Digit Is Five(5).");
                break;
                case 6:
                Console.WriteLine($"The Last Digit Is Six(6).");
                break;
                case 7:
                Console.WriteLine($"The Last Digit Is Seven(7).");
                break;
                case 8:
                Console.WriteLine($"The Last Digit Is Eight(8).");
                break;
                case 9:
                Console.WriteLine($"The Last Digit Is Nine(9).");
                break;
                default:
                Console.WriteLine("Invalid Input.");
                break;
            }
        }
    }
}
