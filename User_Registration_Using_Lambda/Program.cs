namespace User_Registration_Using_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
         
            UserRegistration userRegistration = new UserRegistration();

            while(flag)
            {
                Console.WriteLine("Welcome to User Registration Using Lambda Expression");
                Console.WriteLine("Please enter an option");
                Console.WriteLine("1 : First Name");
                Console.WriteLine("2 : Last Name");
                Console.WriteLine("3 : Email ID");
                Console.WriteLine("4 : Phone Number");
                Console.WriteLine("5 : Password");
                Console.WriteLine("6 : Password atleast numeric");
                Console.WriteLine("0 : Exit");
                Console.Write("ENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        userRegistration.CheckFirstName("Pranav");
                        Console.ReadKey();
                        break;
                    case 2:
                        userRegistration.CheckLastName("Waghmare");
                        Console.ReadKey();
                        break;
                    case 3:
                        userRegistration.CheckEmailID("abc.xyz@bridgelabz.co.in");
                        Console.ReadKey();
                        break;
                    case 4:
                        userRegistration.CheckPhoneNumber("91 9998885552");
                        Console.ReadKey();
                        break;
                    case 5:
                        userRegistration.CheckPassword1("PranavW");
                        Console.ReadKey();
                        break;
                    case 6: 
                        userRegistration.CheckPassword2("PranavW1");
                        Console.ReadKey();
                        break;
                    case 0:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter right option");
                        Console.ReadKey();
                        break;
                }
            }
           
        }
    }
}