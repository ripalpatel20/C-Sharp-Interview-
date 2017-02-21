using System;
using System.Text.RegularExpressions;


namespace ConsoleApplication1
{
     class calculate
    {
        // Member Variables 
        public const double MinValue = -1.7976931348623157E+308;
        public const double MaxValue = 1.7976931348623157E+308;
        public int total =0;


        public int calculateData(double number)
        {
            try
            {
                if (number > MinValue && number < MaxValue)
                {
                    Regex rgx = new Regex("[^0-9]");
                    String new_number = rgx.Replace(number.ToString(), "");
                    int total = 0;
                    foreach (char num in new_number)
                    {
                        total = total + (Convert.ToInt32(Char.GetNumericValue(num)) * 3);
                        total = total % 7;
                    }
                    return total;
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception e)
            {
                Console.Write(e);
                return 0;
            }   
            finally
            {
                Console.Write("Thank you for trying my code\n");
            }         
        }


    }
}
