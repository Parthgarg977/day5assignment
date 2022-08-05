namespace Simple
{
    class P1
    {
        public void Flipcoin()
        {
			int heads = 0;
			Random random = new Random();
			Console.WriteLine("Enter number of flips:");
			int numberOfFlips = Convert.ToInt32(Console.ReadLine());  //	stores number of flips


			if (numberOfFlips < 1)
			{   
				Console.WriteLine("Number must be greater than 0");
			}

			for (int i = 0; i < numberOfFlips; i++)
			{
				double randomValue = random.NextDouble();
				if (randomValue < 0.5)
				{   //	tails
					Console.WriteLine("Tails");
				}
				else
				{   //	heads
					Console.WriteLine("Heads");
					heads++;
				}
			}

			//	prints heads and tails percentages// converting int to double

			Console.WriteLine("Heads Percentage: " + ((double)heads / numberOfFlips)*100+"%");
			Console.WriteLine("Tails Percentage: " + (((double)numberOfFlips - heads) / numberOfFlips)*100+"%");
		}
    }
}