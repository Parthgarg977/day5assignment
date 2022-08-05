namespace Simple
{
    class P2
    {
		public void leapYear()
		{

			Console.WriteLine("Enter year to check: ");
			int year = Convert.ToInt32(Console.ReadLine());   //	year to be checked

			if ((year / 1000) == 0)
			{   //	year is not four digit
				Console.WriteLine("Year should be in 4 digits!!!");
				leapYear();
			}
			else
			{
				if ((year % 4) == 0)
				{   //	leap year
					Console.WriteLine("Leap year");
				}
				else
				{   //	not a leap year
					Console.WriteLine("Not a leap year");
				}
			}

		}
	}
}