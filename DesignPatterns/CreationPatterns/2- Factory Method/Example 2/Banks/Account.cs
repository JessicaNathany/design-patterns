using CreationPatterns._2__Factory_Method.Example_2.Interface;
using System;

namespace CreationPatterns._2__Factory_Method.Example_2.Banks
{
    public class Account : IBanks
    {
        public void GetBalance()
        {
            Console.WriteLine("Your balance account is: 1,500U$");
        }

        public void Transfer()
        {
            GetBalance();
            Console.WriteLine("Transfer was successful");
        }
    }
}
