using System.ComponentModel.Design;
using System.Data;
using System.Runtime;

namespace ConsoleAppProject_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Paws and Claws\n");
            Console.WriteLine("Please select one of the following options:\n ");
            Console.WriteLine("Enter 1 to : Set up your account\n");
            Console.WriteLine("Enter 2 to : Go you your Dashboard\n");


            int userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1)
            {
                Account.
                string message1 = "Welcome to your Account setup.";
                Console.WriteLine(message1);

            }
            else if (userChoice == 2)
            {
                string message2 = "Welcome to your Dashboard.";
                Console.WriteLine(message2);
            }
            else if(userChoice == 3)
            {
                string message3 = "Invalid entry please try again";
                Console.WriteLine(message3);
            }

            Console.ReadLine();
               
        }
        class Account
        {
            public void AccountMain()
            {
                private string _name { get; set; }
            private string _breed { get; set; }
            private string _gender { get; set; }
            private int _age { get; set; }
            private double _weight { get; set; }
            private string _fixed { get; set; }
        }
        

          
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            public string Breed
            {
                get { return this._breed; }
                set { this._breed = value; }
            }
            public string Gender
            {

                get { return this._gender; }
                set { this._gender = value; }

            }
        
        }
    }

    
}