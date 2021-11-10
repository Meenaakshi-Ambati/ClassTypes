using System;

namespace ClassTypes
{
    class  Customer
    {
        string _firstname;
        string _lastname;

        public Customer(string firstname, string lastname )
         {
            _firstname = firstname;
            _lastname = lastname;
         }

          public string PrintFullName()
           {
              return _firstname + " " + _lastname;
           }

           ~Customer()
           {


           }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Meenaakshi", "Ambati");
            Console.WriteLine(c1.PrintFullName());
        }
    }
}
