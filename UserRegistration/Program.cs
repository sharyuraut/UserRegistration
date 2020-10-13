using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        public static String passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d].{8,}$";
        public static String MobilePattern = "^[\\+]{1}[91]{2}\\s{1}[0-9]{10}$";
        public static String EmailPattern = @"^([a-z0-9.+_-]+@(?:[a-z0-9]+?\.)[a-z0-9.]+)$";
        public static String namePattern = @"^[A-Z]{1}[a-z]{2,}$";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program!");
            bool validate = true;
            int flag = 0;
            Program check = new Program();

            while (validate)
            {
                try
                {
                    if (flag == 0)
                        Console.WriteLine("Enter your first name: ");
                    else
                        Console.WriteLine("Enter your first name again: ");

                    flag = 1;
                    string FirstName = Console.ReadLine();

                    bool Result = check.validateField(FirstName, namePattern);
                    if (Result)
                        validate = false;
                    else
                        Console.WriteLine("Not a valid first name.");
                }
                catch (UserRegistrationCustomException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            validate = true;
            flag = 0;

            while (validate)
            {
                try
                {
                    if (flag == 0)
                        Console.WriteLine("Enter your last name: ");
                    else
                        Console.WriteLine("Enter your last name again: ");

                    flag = 1;
                    string LastName = Console.ReadLine();

                    bool Result = check.validateField(LastName, namePattern);
                    if (Result)
                        validate = false;
                    else
                        Console.WriteLine("Not a valid last name.");
                }
                catch (UserRegistrationCustomException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            validate = true;
            flag = 0;

            while (validate)
            {
                try
                {
                    if (flag == 0)
                        Console.WriteLine("Enter your EmailId: ");
                    else
                        Console.WriteLine("Enter your EmailId again: ");

                    flag = 1;
                    string EmailId = Console.ReadLine();

                    bool Result = check.validateField(EmailId, EmailPattern);
                    if (Result)
                        validate = false;
                    else
                        Console.WriteLine("Not a valid last name.");
                }
                catch (UserRegistrationCustomException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            validate = true;
            flag = 0;

            while (validate)
            {
                try
                {
                    if (flag == 0)
                        Console.WriteLine("Enter your Mobile number: ");
                    else
                        Console.WriteLine("Enter your Mobile number again: ");

                    flag = 1;
                    string MobileNumber = Console.ReadLine();

                    bool Result = check.validateField(MobileNumber, MobilePattern);
                    if (Result)
                        validate = false;
                    else
                        Console.WriteLine("Not a valid Mobile number.");
                }
                catch (UserRegistrationCustomException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            validate = true;
            flag = 0;

            while (validate)
            {
                try
                {
                    if (flag == 0)
                        Console.WriteLine("Enter your Password: ");
                    else
                        Console.WriteLine("Enter your Password again: ");

                    flag = 1;
                    string Password = Console.ReadLine();

                    bool Result = check.validateField(Password, passwordPattern);
                    if (Result)
                        validate = false;
                    else
                        Console.WriteLine("Not a valid Password.");
                }
                catch (UserRegistrationCustomException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("Registration Successful!!!");
        }

        private bool validateField(string Field, string Pattern)
        {
            return Regex.IsMatch(Field, Pattern);
        }
    }
}