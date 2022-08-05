namespace Simple
{
    class P5
    {
        public void Factors()
        {
			Console.WriteLine("Enter number: ");
			int num = Convert.ToInt32(Console.ReadLine());
			if (num < 1)
			{
				Console.WriteLine("Number should be greater than 0");
			}
			else
			{
				Console.WriteLine("The prime factors are: ");

				for (int i = 2; i * i <= num; i++)
				{
					//	checks if number is factor and prime
					if (((num % i) == 0) && isPrime(i))
					{
						Console.Write(i + " ");
						int oppositeNum = num / i;  //	checks if the divider is a prime number
						if ((oppositeNum != i) && isPrime(oppositeNum))
						{
							Console.Write((oppositeNum) + " ");
						}
					}
				}
				Console.WriteLine();
			}
		}

		/** checks if the number is prime **/
		static Boolean isPrime(int number)
		{
			for (int i = 2; i * i <= number; i++)
			{
				if ((number % i) == 0)
				{
					return false;
				}
			}
			return true;
		}

	}
}