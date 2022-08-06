namespace Simple
{
    class P8
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Entered number " + number + "is even");
            }
            else
                Console.WriteLine("Entered number " + number + "is odd");
        }
    }
}