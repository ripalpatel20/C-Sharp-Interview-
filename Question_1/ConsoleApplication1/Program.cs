using System;

namespace ConsoleApplication1
{
    class Program
    {              
        //Entry point
        public static void Main(string[] args)
        {
            // object instantiation  
            calculate obj = new calculate();
            Console.WriteLine("Please Enter Number :");
            double number = Convert.ToDouble(Console.ReadLine());
            int new_number = obj.calculateData(number);
            Console.WriteLine("New number after multiplication, summation and modulo is : " + new_number);



        }
    }
}
