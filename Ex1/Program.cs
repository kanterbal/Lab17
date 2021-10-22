using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<string> person1 = new Account<string>();
            person1.Number = "123";
            person1.Enter();
            person1.Print();
            Account<int> person2 = new Account<int>();
            person2.Number = 456;
            person2.Enter();
            person2.Print();
            Account<double> person3 = new Account<double>();
            person3.Number = 7.89;
            person3.Enter();
            person3.Print();
            Console.ReadKey();
        }
    }
    class Account<T>
    {
        T number;
        double balance;
        string name;

        
        public T Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void Enter()
        {
            Console.Write("Vvedite FIO: ");
            name = Console.ReadLine();
            Console.Write("Vvedite balans sceta: ");
            balance = Convert.ToDouble(Console.ReadLine());

        }
        public void Print()
        {
            Console.WriteLine("FIO: {0}", name);
            Console.WriteLine("Nomer sceta: {0}", number);
            Console.WriteLine("Balans sceta: {0}", balance);
        }

    }
}
