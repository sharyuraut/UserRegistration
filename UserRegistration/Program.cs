using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program!");

            Boolean validate = true;
            int flag = 0;
            Program check = new Program();

            while (validate)
            {
                if (flag == 0)

                    Console.WriteLine("Enter your first name: ");
                else
                    Console.WriteLine("Enter your first name again: ");

                flag = 1;
                string FirstName = Console.ReadLine();

                Boolean Result = check.validateName(FirstName);
                if (Result)
                    validate = false;
                else
                    Console.WriteLine("Not a valid first name.");
            }
            validate = true;

            while (validate)
            {
                if (flag == 0)
                    Console.WriteLine("Enter your last name: ");
                else
                    Console.WriteLine("Enter your last name again: ");

                flag = 1;
                string LastName = Console.ReadLine();

                Boolean Result = check.validateName(LastName);
                if (Result)
                    validate = false;
                else
                    Console.WriteLine("Not a valid last name.");

            }
        }

        private Boolean validateName(String name)
        {
            String namePattern = @"^[A-Z]{1}[a-z]{2,}$";
            Regex Pattern = new Regex(namePattern);

            Boolean result = Pattern.IsMatch(name);

            return result;
        }
    }
}
