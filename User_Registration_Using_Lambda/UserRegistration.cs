using System;
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
                Console.WriteLine("\n\tValid");
            }
            else
            {
                Console.WriteLine("\n\tInvalid");
            }
        }
        public void CheckLastName(string lastName)
        {
            if (userDetails.Any(x => x.LastName.IsMatch(lastName)))
            {
                Console.WriteLine("\n\tValid");
            }
            else
            {
                Console.WriteLine("\n\tInvalid");
            }
        }

        public void CheckEmailID(string emailId)
        {
            if (userDetails.Any(x => x.EmailID.IsMatch(emailId)))
            {
                Console.WriteLine("\n\tValid");
            }
            else
            {
                Console.WriteLine("\n\tInvalid");
            }
        }

        public void CheckPhoneNumber(string phoneNumber)
        {
            if (userDetails.Any(x => x.PhoneNumber.IsMatch(phoneNumber)))
            {
                Console.WriteLine("\n\tValid");
            }
            else
            {
                Console.WriteLine("\n\tInvalid");
            }
        }

        public void CheckPassword1(string password)
        {
            if (userDetails.Any(x => x.Password1.IsMatch(password)))
            {
                Console.WriteLine("\n\tValid");
            }
            else
            {
                Console.WriteLine("\n\tInvalid");
            }
        }

        public void CheckPassword2(string password)
        {
            if (userDetails.Any(x => x.Password2.IsMatch(password)))
            {
                Console.WriteLine("\n\tValid");
            }
            else
            {
                Console.WriteLine("\n\tInvalid");
            }
        }

        public void CheckPassword3(string password)
        {
            if (userDetails.Any(x => x.Password3.IsMatch(password)))
            {
                Console.WriteLine("\n\tValid");
            }
            else
            {
                Console.WriteLine("\n\tInvalid");
            }
        }

        public void CheckPassword4(string password)
        {
            if (userDetails.Any(x => x.Password4.IsMatch(password)))
            {
                Console.WriteLine("\n\tValid");
            }
            else
            {
                Console.WriteLine("\n\tInvalid");
            }
        }

        public void SampleEmails(string password)
        {
            if (userDetails.Any(x => x.SampleEmails.IsMatch(password)))
            {
                Console.WriteLine("\n\tValid");
            }
            else
            {
                Console.WriteLine("\n\tInvalid");
            }
        }


    }
}
