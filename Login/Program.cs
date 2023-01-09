using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRegistered = false;
            bool isLogined = false;
            string username = "fty";
            string password = "2343";
            string registered;
            string enteredusername;
            string enteredpassword;


            Console.WriteLine("Are you registered: Y/N");
            registered = Console.ReadLine();
            if (registered.Equals("Y"))
                {
                isRegistered = true;
                Login();
            }
            else
            {
                isRegistered = false;
                Register();
            }

            if (isRegistered == false)
            {
                
            }
            if (isRegistered == true) 
            {
                
            }
            Console.Read();


            void Register()
            {
                Console.WriteLine("Please Create a new Account");
                Console.Write("Username :");
                username = Console.ReadLine();
                Console.Write("Password :");
                password = Console.ReadLine();
                isRegistered = true;
                Login();
            }
            void Login()
            {
                Console.WriteLine("Please Enter your Username");
                enteredusername = Console.ReadLine();
                Console.WriteLine("Please Enter your Password");
                enteredpassword = Console.ReadLine();
                if (enteredusername == username && enteredpassword == password)
                {
                    Console.WriteLine("You are succesfully loged in");
                }
                else
                {
                    Console.WriteLine("Username or password is not correct");
                    Login();
                }
            }
            
        }
    }
}
