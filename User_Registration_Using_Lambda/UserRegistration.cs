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

      
    }
}
