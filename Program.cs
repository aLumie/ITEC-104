using System;

namespace Struct
{
    public class StructAct
    {
        struct Employee
        {
            public string firstName;
            public string lastName;
            public int age;
            public string completedTraining;

        }

        public static void Main(string[] args)
        {
            {
                Employee employee1;

                Console.WriteLine("Enter your First Name: ");
                employee1.firstName = Console.ReadLine();

                Console.WriteLine("Enter your Last Name: ");
                employee1.lastName = Console.ReadLine();

                Console.WriteLine("Enter your Age: ");
                employee1.age = int.Parse(Console.ReadLine());

                Console.WriteLine("Do you have a completed training?");
                employee1.completedTraining = Console.ReadLine();

                Console.WriteLine("\nEmployee's Information");
                Console.WriteLine("Name : " + employee1.firstName + " " + employee1.lastName);
                Console.WriteLine("Age : " + employee1.age);
                Console.WriteLine("Completed Training? " + employee1.completedTraining);


            }

        }
    }
}

    
