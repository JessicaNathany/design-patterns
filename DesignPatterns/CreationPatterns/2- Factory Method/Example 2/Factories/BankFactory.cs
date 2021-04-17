using CreationPatterns._2__Factory_Method.Example_2.Interface;

namespace CreationPatterns._2__Factory_Method.Example_2.Factories
{
    abstract class BankFactory
    {
        public void GetMoney()
        {
            IBanks banks = CreateAccount();
            banks.Transfer();
        }

        protected abstract IBanks CreateAccount();
    }
}
