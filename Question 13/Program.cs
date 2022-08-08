using System;

namespace Question_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number.");
            int num = int.Parse(Console.ReadLine());
            int binVal;
            int decVal = 0;
            binVal = num;
            int baseVal = 1;
            int rem;
            while(num > 0){
                rem = num % 10;
                decVal = decVal + rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }
            Console.Write("Binary Number =" + binVal);
            Console.WriteLine();
            Console.Write("Decimal Number =" + decVal);
        }
    }
}
