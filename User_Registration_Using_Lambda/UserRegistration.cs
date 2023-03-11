﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration_Using_Lambda
{
    public class UserRegistration
    {

        List<UserDetails> userDetails = new List<UserDetails>();
        public UserRegistration()
        {
            UserDetails user = new UserDetails();
            userDetails.Add(user);
        }
        public void CheckFirstName(string firstName)
        {
            if (userDetails.Any(x => x.FirstName.IsMatch(firstName)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void CheckLastName(string lastName)
        {
            if (userDetails.Any(x => x.LastName.IsMatch(lastName)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}