namespace Simple
{
    class P3
    {
        public void PowerOf2()
        {
			Console.WriteLine("Enter power of 2: ");
			int power = Convert.ToInt32(Console.ReadLine()); 

			if ((power >= 0) && (power < 31))
			{   //	prints values
				Console.WriteLine("Power \tAnswer\t Leap Year");
				for (int i = 0; i <= power; i++)
				{
					Console.WriteLine(" "+i + "\t" + (int)(Math.Pow(2, i)) + "\t  " + leap(Math.Pow(2, i)));
				}
			}
			else
			{   //	power is out of the limits
				Console.WriteLine("Power should be positive and less than 31");
				PowerOf2();
			}
			String leap(double i)
			{
				if (i > 999)
				{
					return "Yes";
				}
				return "No";
			}
		}
    }
}