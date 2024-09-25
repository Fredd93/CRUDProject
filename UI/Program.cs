using Model;
using Service;
using Service;
namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService userdb = new UserService();
            Console.Write("Write the first name of an employee: ");
            string firstname = Console.ReadLine();
            try
            {
                User user = userdb.READUser(firstname);
                Console.WriteLine("Found user!");
                Console.WriteLine(user.First_Name + " " + user.Last_Name);
                Console.WriteLine(user.Email);
                Console.WriteLine(user.Role);
            }
            catch
            {
                Console.WriteLine("User '" + firstname + "' was not found!");
            }
            
            
            
        }
    }
}
