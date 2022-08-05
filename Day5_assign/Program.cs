using System;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for flipcoin_program \nEnter 2 for Leap Year\nEnter 3 for Power of 2 program\nEnter 4 for Harmonic number program\nEnter 5 for Factors program\nEnter 6 for quotient program\nEnter 7 for Swap number program\nEnter 8 for Even/odd program\nEnter 9 for Vowel/consonant program\nEnter 10 for largest among 3 numbers program ");
            byte user_input=(byte)Convert.ToInt32(Console.ReadLine());
            switch (user_input)
            {
                case 1:
                    P1 c1 = new P1();
                    c1.Flipcoin();
                    break;
                    case 2:
                    P2 c2 = new P2();
                    c2.leapYear();
                    break;
                case 3:
                    P3 c3 = new P3();
                    c3.PowerOf2();
                    break;
                default: Console.WriteLine("Please enter correct number");
                    break;

            }
                
            

        }
    }
}