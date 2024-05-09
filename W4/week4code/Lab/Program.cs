
using System;

namespace midterm
{
    class Project{
        public class Person 
    {
        private string FirstName;
        private string MiddleName;
        private string LastName;
        private string Street1;
        private string Street2;
        private string City;
        private string State;
        private string Zip;
        private string PhoneNumber;
        private string Email;

        public string firstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
        public string middleName
        {
            get
            {
                return MiddleName;
            }
            set
            {
                MiddleName = value;
            }
        }
        public string lastName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }
        public string street1
        {
            get
            {
                return Street1;
            }
            set
            {
                Street1 = value;
            }
        }
        public string street2
        {
            get
            {
                return Street2;
            }
            set
            {
                Street2 = value;
            }
        }
        public string city
        {
            get
            {
                return ;
            }
            set
            {
                City = value;
            }
        }
        public string state
        {
            get
            {
                return State;
            }
            set
            {
                State = value;
            }
        }
        public string zip
        {
            get
            {
                return Zip;
            }
            set
            {
                Zip = value;
            }
        }
        public string phoneNumber
        {
            get
            {
                return PhoneNumber;
            }
            set
            {
                PhoneNumber = value;
            }
        }
        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
    }
    static void Main(string[] args) // get ye data
    {
        Person temp = new Person(); 

        Console.Write("\nPlease Enter your First Name: ");
        temp.FirstName = Console.ReadLine();

        Console.Write("\nPlease Enter your Middle Name: ");
        temp.MiddleName = Console.ReadLine();

        Console.Write("\nPlease Enter your Last Name: ");
        temp.LastName = Console.ReadLine();

        Console.Write("\nPlease Enter your Street: ");
        temp.Street1 = Console.ReadLine();

        Console.Write("\nPlease Enter a second Street: ");
        temp.Street2 = Console.ReadLine();

        Console.Write("\nPlease Enter your City: ");
        temp.City = Console.ReadLine();

        Console.Write("\nPlease Enter your areas Zip: ");
        temp.Zip = Console.ReadLine();

        Console.Write("\nPlease Enter your Phone Number: ");
        temp.PhoneNumber = Console.ReadLine();

        Console.Write("\nPlease Enter your Email: ");
        temp.Email = Console.ReadLine();

        //show ye data

        Console.Write($"Here is the information you gave us:\nFirst Name:{temp.FirstName}\nMiddle Name: {temp.MiddleName}\nLast Name:{temp.LastName}\nStreet[1]:{temp.Street1}\nStreet[2]:{temp.Street2}\nCity:{temp.City}\nZip:{temp.Zip}\nPhone Number:{temp.PhoneNumber}\nEmail: {temp.Email}");




    }


    }
}