namespace Simple
{
    class P7
    {
        public void SwapNumber()
        {
            Console.WriteLine("Enter 1st number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int temp = n1 + n2;
            n1=n2;
            n2 = temp - n1;
            Console.WriteLine("New 1st number: " + n1);
            Console.WriteLine("New 2nd number: " + n2);



        }


        }
    }
