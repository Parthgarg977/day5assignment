using System.Linq;
namespace Simple
{
    class P6
    {
        public void quoAndRem()
        {
            Console.WriteLine("Enter Dividend");
            String dividend = Console.ReadLine();
            Console.WriteLine("Enter Divisor");
            String divisor = Console.ReadLine();
            bool a=dividend.All(char.IsDigit);
            bool b=divisor.All(char.IsDigit);
            if (a == true && b == true)
            {
                int q1 = Convert.ToInt32(dividend);
                int q2 = Convert.ToInt32(divisor);
                int quotient = q1 / q2;
                int remainder = q1 % q2;
                Console.WriteLine("Dividend:" + dividend + "\n" + "Divisor:" + divisor);
                // Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
                Console.WriteLine("Quotient = " + quotient);
                Console.WriteLine("Remainder = " + remainder);
            }
            else if (a == false && b == true)
            {
                double d = Convert.ToDouble(dividend);
                int q2 = Convert.ToInt32(divisor);
                var quotient = d / q2;
                var remainder =d % q2;
                Console.WriteLine("Dividend:"+dividend+"\n"+ "Divisor:"+divisor);
                Console.WriteLine("Quotient = " + quotient);
                Console.WriteLine("Remainder = " + remainder);
            }
            else if (a == true && b == false)
            {
                int d = Convert.ToInt32(dividend);
                double d2 = Convert.ToDouble(divisor);
                var quotient = d / d2;
                var remainder = d % d2;
                Console.WriteLine("Dividend:" + dividend + "\n" + "Divisor:" + divisor);
                //Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
                Console.WriteLine("Quotient = " + quotient);
                Console.WriteLine("Remainder = " + remainder);
            }
            else if (a == false && b == false)
            {
                double d = Convert.ToDouble(dividend);
                double d2 = Convert.ToDouble(divisor);
                var quotient = d / d2;
                var remainder = d % d2;
                Console.WriteLine("Dividend:" + dividend + "\n" + "Divisor:" + divisor);
                //Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
                Console.WriteLine("Quotient = " + quotient);
                Console.WriteLine("Remainder = " + remainder);
            }

        }
    }
}