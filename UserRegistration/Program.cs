﻿using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        public String passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d].{8,}$";
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
            validate = true;
            flag = 0;

            while (validate)
            {
                if (flag == 0)
                    Console.WriteLine("Enter your Password: ");
                else
                    Console.WriteLine("Enter your Password again: ");

                flag = 1;
                string Password = Console.ReadLine();

                bool Result = check.validatePassword(Password);
                if (Result)
                    validate = false;
                else
                    Console.WriteLine("Not a valid Password.");
            }

            Console.WriteLine("Registration Successful!!!");
        }

        //Validates Password given by user
        private bool validatePassword(string password)
        {
            //String passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d].{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }

        //Validates MobileNumber of user
        private bool validatemobileNumber(string MobileNumber)
        {
            String MobilePattern = "^[\\+]{1}[91]{2}\\s{1}[0-9]{10}$";
            return Regex.IsMatch(MobileNumber, MobilePattern);
        }

        //Validates EmailId of user
        private bool validateEmail(string emailId)
        {
            String EmailPattern = @"^([a-z0-9.+_-]+@(?:[a-z0-9]+?\.)[a-z0-9.]+)$";
            return Regex.IsMatch(emailId, EmailPattern);
        }

        //Validates Name(First and Last Name) Field of user
        private bool validateName(String name)
        {
            String namePattern = @"^[A-Z]{1}[a-z]{2,}$";
            return Regex.IsMatch(name, namePattern);
        }
    }
}