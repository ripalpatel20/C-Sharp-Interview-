using System;

namespace Question_2
{
    public interface ITransactions
    {
        // interface members
        void showTransaction();
        Tuple<int, int> getAmount();
    }
    public class Transaction : ITransactions
    {
        private int a;
        private int b;
        private int e;
        private int c;
        private int d;      

        public Transaction(int A, int B, int E)
        {
            a = A;
            b = B;
            e = E;
        }

        public Tuple<int, int> getAmount()
        {
       
            c = (a + b) * 2 * e;
            d = c * (a + b);
            var tuple = new Tuple<int, int>(c,d);
            return tuple;

        }

        public void showTransaction()
        {
            Console.WriteLine("C = {0}",getAmount().Item1);
            Console.WriteLine("D = {0}", getAmount().Item2);
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            
            Transaction t1 = new Transaction(5, 32, 103);            
            t1.showTransaction();            
            Console.ReadKey();
        }
    }
}
