namespace Simple
{
    class P4
    {
        public void HarmonicNumber()
        {
			Console.WriteLine("Enter position in series: ");
			int n = Convert.ToInt32(Console.ReadLine());  //	position of the element in the series
			if (n < 1)
			{   // entered value 0 or negative
				Console.WriteLine("Number should be greater than 0");
				HarmonicNumber();
			}
			else
			{   //	prints elemnt in the series
				Console.WriteLine(n + "th harmonic number is: " +
							((double)1 / n));
			}
		}
    }
}