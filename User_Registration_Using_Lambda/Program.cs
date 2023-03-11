namespace User_Registration_Using_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Welcome to User Registration Using Lambda Expression");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1 : First Name");
            Console.WriteLine("0 : Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            UserRegistration userRegistration = new UserRegistration();

            while(flag)
            {
                switch (option)
                {
                    case 1:
                        userRegistration.CheckFirstName("Pranav");
                        break;
                    case 0:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter right option");
                        break;
                }
            }
           
        }
    }
}