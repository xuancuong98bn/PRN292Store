using System;

namespace Q1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Payment payment = new Payment() { Amount = 1000 };
            payment.AmountChanged += notifyAmountChanged;// your handling function
            payment.Amount = 990;
            Console.WriteLine( "Tax:" + payment.ComputeTax());
        }

        public static void notifyAmountChanged(float oldValue, float newValue)
        {
            Console.WriteLine("Amount changed – old value: " + oldValue + ", new value : " + newValue + "");
        }
    }
}
