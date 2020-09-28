using System;
using CSharpSection_2.Classes;

namespace CSharpSection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //This would call the class that did math and do it with floats.
            Console.WriteLine("Subtracted Number equal " + Simplemath.Add(432.23f, 54523.3f));
            Console.WriteLine("Subtracted Number equal " + Simplemath.Subtract(432.23f, 54523.3f)); //n1, n2));
            Console.WriteLine("Multiplied Number equal " + Simplemath.multiply(432.23f, 54523.3f)); //n1, n2));
            Console.WriteLine("Divided Number equal " + Simplemath.divide(432.23f, 54523.3f)); //n1, n2));*/

            //This would get the remainer of two numbers.
            Advancemath am = new Advancemath();
            Console.WriteLine(am.Remainer(7, 3));
            Console.ReadLine();

            //This was to create an adult and child bank account object
            BankAccount bankaccount1 = new BankAccount(124321.32f, "Jane Doe");
             Console.WriteLine(bankaccount1.Balance);
             ChildBankAccount bankaccount2 = new ChildBankAccount(1342.32f, "John Doe", "Jane Doe");

            //This would change the values of the bank accounts.
             Console.WriteLine(bankaccount1.AddBalance (100f));
             Console.WriteLine(bankaccount2.AddBalance(-1421.43f, true));

             Console.ReadLine();

            //This would call a class to get information about the bank accounts
            GetData();

        }

        //This would simulate accessing a server for bank acounts
        async static void GetData()
        {
            BankAccount bankAccount = new BankAccount(543543, "Jane");
            Console.WriteLine("Log in");
            var task = await bankAccount.GetData();
            Console.WriteLine(task);
            Console.ReadLine();
        }
    }
    interface IOperation
    {
        float Remainer(float dividend, float divisor);
    }

    //This was a class to do math
   class Simplemath
    {
        public static float Add(float n1, float n2)
        {
            float result = n1 + n2;
            return result;
        }

        public static float Subtract(float n1, float n2)
        {
            return n1 - n2;
        }

        public static float multiply(float n1, float n2)
        {
            return n1 * n2;
        }

        public static float divide(float n1, float n2)
        {
            return n1 / n2;
        }
    }

    //This is a class that inherited from the Simplemath and IOperation class.
    class Advancemath : Simplemath, IOperation
    {
        public float Remainer(float dividend, float divisor)
        {
            return dividend % divisor;
        }
    }
}
