using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    class UserRegistrationCustomException : Exception
    {
        public UserRegistrationCustomException(string message) : base(message)
        {

        }
    }
}
