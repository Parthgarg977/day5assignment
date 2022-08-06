namespace Simple
{
    class P10
    {
        public void LargestAmongThree()
        {
            Console.Write("Input the 1st number :");
           int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
           int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
        }
    }
    }
