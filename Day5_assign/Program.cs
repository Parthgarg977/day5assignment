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
                case 4:
                    P4 c4 = new P4();
                    c4.HarmonicNumber();
                    break;
                case 5:
                    P5 c5 = new P5();
                    c5.Factors();
                    break;
                case 6:
                    P6 c6 = new P6();
                    c6.quoAndRem();
                    break;
                case 7:
                    P7 c7 = new P7();
                    c7.SwapNumber();
                    break;
                case 8:
                    P8 c8 = new P8();
                    c8.EvenOrOdd();
                    break;
                case 9:
                    P9 c9 = new P9();
                    c9.VowelorConsonant();
                    break;
                case 10:
                    P10 c10 = new P10();
                    c10.LargestAmongThree();
                    break;
                default: 
                    Console.WriteLine("Please enter correct number");  
                    break;

            }
                
            

        }
    }
}