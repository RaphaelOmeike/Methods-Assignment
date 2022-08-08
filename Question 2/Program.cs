using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
        // Chapter 9 :- Methods.
        // Question 2.
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter The 1st Number.");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The 2nd Number.");
            int input2 = int.Parse(Console.ReadLine());
            GetMax(input1,input2);
        }
        public static void GetMax(int num1, int num2)
        {
            if(num2 > num1)
            {
                Console.WriteLine($"The Largest Of The Two(2) Numbers Is {num2}.");
            }
            else if(num1 > num2)
            {
                Console.WriteLine($"The Largest Of The Two(2) Numbers Is {num1}.");
            }
            else{
                Console.WriteLine($"The Largest Of The Two(2) Numbers Is {num1}.");
            }
            Console.WriteLine("Enter The 1st Number.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The 2nd Number.");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The 3rd Number.");
            int c = int.Parse(Console.ReadLine());
            int largeI = 0;
            if(a != b)
            {
                if(a > b)
                {
                    largeI = a;
                }
                else if(b > a)
                {
                    largeI = b;
                }
            }
            else{
                largeI = a;
            }
            if(largeI != c)
            {
                if(largeI > c)
                {
                    Console.WriteLine($"The Largest Number Is, {largeI}");
                }
                else if(c > largeI)
                {
                    largeI = c;
                    Console.WriteLine($"The Largest Number Is, {largeI}");
                }
            }
            else{
                Console.WriteLine($"All The Numbers Are Equal.");
            }
        }
    }
}
