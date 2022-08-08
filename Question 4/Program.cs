using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
        // Question 4.
            Console.WriteLine("Program To Print Cards.");
            for(int i = 1; i < 5; i++)
            {
                switch(i)
                {
                    case 1:
                    Console.WriteLine("1st Suit - Club.");
                    break;
                    case 2:
                    Console.WriteLine("2nd Suit - Diamond.");
                    break;
                    case 3:
                    Console.WriteLine("3rd Suit - Heart.");
                    break;
                    case 4:
                    Console.WriteLine("4th Suit - Spades.");
                    break;
                    default:
                    Console.WriteLine("Invalid Input.");
                    break;
                }
                for(int j = 2; j < 15; j++)
                {
                    switch(j)
                    {
                        case 2:
                        Console.WriteLine("Card - 2(Two).");
                        break;
                        case 3:
                        Console.WriteLine("Card - 3(Three).");
                        break;
                        case 4:
                        Console.WriteLine("Card - 4(Four).");
                        break;
                        case 5:
                        Console.WriteLine("Card - 5(Five).");
                        break;
                        case 6:
                        Console.WriteLine("Card - 6(Six).");
                        break;
                        case 7:
                        Console.WriteLine("Card - 7(Seven).");
                        break;
                        case 8:
                        Console.WriteLine("Card - 8(Eight).");
                        break;
                        case 9:
                        Console.WriteLine("Card - 9(Nine).");
                        break;
                        case 10:
                        Console.WriteLine("Card - 10(Ten).");
                        break;
                        case 11:
                        Console.WriteLine("Card - J.");
                        break;
                        case 12:
                        Console.WriteLine("Card - Q.");
                        break;
                        case 13:
                        Console.WriteLine("Card - K.");
                        break;
                        case 14:
                        Console.WriteLine("Card - A.");
                        break;
                        default:
                        Console.WriteLine("Invalid Input.");
                        break;
                    }
                }
            }
        }
    }
}
