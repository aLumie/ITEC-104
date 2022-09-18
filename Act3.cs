using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] email = { "email1@gmail.com", "email2@gmail.com", "email@gmail.com" };
            string[] username = { "username1", "username2", "username3" };
            string[] password = { "password1", "password2", "password3" };

            //Input the index value
            Console.WriteLine("Index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            // Displaying the values
            Console.WriteLine("Email: " + email[index]);
            Console.WriteLine("Username: " + username[index]); 
            Console.WriteLine("Password: " + password[index]);


        }
        

     
    }
}
