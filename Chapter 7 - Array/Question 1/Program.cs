using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }
            foreach(var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
