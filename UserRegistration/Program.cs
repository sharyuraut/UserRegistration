using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program!");
            bool validate = true;
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
                bool Result = check.validateName(FirstName);
                if (Result)
                    validate = false;
                else
                    Console.WriteLine("Not a valid first name.");
            }
            validate = true;
            flag = 0;

            while (validate)
            {
                if (flag == 0)
                    Console.WriteLine("Enter your last name: ");
                else
                    Console.WriteLine("Enter your last name again: ");

                flag = 1;
                string LastName = Console.ReadLine();
                bool Result = check.validateName(LastName);
                if (Result)
                    validate = false;
                else
                    Console.WriteLine("Not a valid last name.");
            }
            validate = true;
            flag = 0;

            while (validate)
            {
                if (flag == 0)
                    Console.WriteLine("Enter your EmailId: ");
                else
                    Console.WriteLine("Enter your EmailId again: ");

                flag = 1;
                string EmailId = Console.ReadLine();
                bool Result = check.validateEmail(EmailId);
                if (Result)
                    validate = false;
                else
                    Console.WriteLine("Not a valid last name.");
            }
            validate = true;
            flag = 0;

            while (validate)
            {
                if (flag == 0)
                    Console.WriteLine("Enter your Mobile number: ");
                else
                    Console.WriteLine("Enter your Mobile number again: ");

                flag = 1;
                string MobileNumber = Console.ReadLine();

                bool Result = check.validatemobileNumber(MobileNumber);
                if (Result)
                    validate = false;
                else
                    Console.WriteLine("Not a valid Mobile number.");
            }
        }
        private bool validatemobileNumber(string MobileNumber)
        {
            String MobilePattern = @"^[\\+]{1}[91]{2}\\s{1}[0-9]{10}$";
            return Regex.IsMatch(MobileNumber, MobilePattern);
        }

        private bool validateEmail(string emailId)
        {
            String EmailPattern = @"^[a-z][a-z0-9]+(\.[a-z0-9]+)?@[a-z0-9]+\.[a-z]{2,}(\.[a-z]{2,})?$";
            return Regex.IsMatch(emailId, EmailPattern);
        }

        private bool validateName(String name)
        {
            String namePattern = @"^[A-Z]{1}[a-z]{2,}$";
            return Regex.IsMatch(name, namePattern);
        }
    }
}