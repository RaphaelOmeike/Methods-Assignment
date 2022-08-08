using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number.");
            int num = int.Parse(Console.ReadLine());
            ReverseOrder(num);
        }
        public static void ReverseOrder(int number)
        {
            string name = number.ToString();
            string output = "";
            for(int i = name.Length - 1; i >= 0; i--)
            {
                output += name[i];
            }
            Console.WriteLine(output);
            return;
        }
    }
}
