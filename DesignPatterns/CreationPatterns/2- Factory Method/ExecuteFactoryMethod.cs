using CreationPatterns._2__Factory_Method.Example_1.Factories;
using CreationPatterns._2__Factory_Method.Example_2.Factories;
using CreationPatterns._2__Factory_Method.Example_2.Factory;
using CreationPatterns._2__Factory_Method.Example_3.Factories;
using System;

namespace DesignPatterns._1__Creational._1._2_Factory_Method
{
    public class ExecuteFactoryMethod
    {
        public void Transport()
        {
            Console.WriteLine("Select a service the type of service");
            Console.WriteLine();
            Console.WriteLine("1- Uber");
            Console.WriteLine("2- Loggi");
            Console.WriteLine("3- Bike");

            var option = Console.ReadKey();
            Transport transport = null;

            switch (option.KeyChar)
            {
                case '1':
                    transport = new CarTransport();
                    break;

                case '2':
                    transport = new MotorcycleTransport();
                    break;

                case '3':
                    transport = new BikeTransport();
                    break;
            }

            if (transport != null) { transport.StartTransport(); }

            Console.ReadLine();
        }

        public void Banks()
        {
            Console.WriteLine("Select an account");
            Console.WriteLine();
            Console.WriteLine("1- Account");
            Console.WriteLine("2- Investment Account");

            var option = Console.ReadKey();
            BankFactory bank = null;

            switch (option.KeyChar)
            {
                case '1':
                    bank = new AccountFactory();
                    break;

                case '2':
                    bank = new InvestmentAccountFactory();
                    break;
              
            }

            if (bank != null) { bank.GetMoney(); }

            Console.ReadLine();
        }

        public void Suppliers()
        {
            Console.WriteLine("type 1 to enter");
            Console.WriteLine();

            var option = Console.ReadKey();
            SupplierProductsFactory supplierProducts = null;

            switch (option.KeyChar)
            {
                case '1':
                    supplierProducts = new SupplierFactory();
                    break;
            }

            if (supplierProducts != null) 
                supplierProducts.GetProductsSupplier(); 

            Console.ReadLine();
        }
    }
}
