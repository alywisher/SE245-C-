
using System;

namespace midterm
{
    class Project
    {
        public class Person
        {
            private string firstName;
            private string middleName;
            private string lastName;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private string zip;
            private string phoneNumber;
            private string email;

            public string FirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
                }
            }
            public string MiddleName
            {
                get
                {
                    return middleName;
                }
                set
                {
                    middleName = value;
                }
            }
            public string LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                }
            }
            public string Street1
            {
                get
                {
                    return street1;
                }
                set
                {
                    street1 = value;
                }
            }
            public string Street2
            {
                get
                {
                    return street2;
                }
                set
                {
                    street2 = value;
                }
            }
            public string City
            {
                get
                {
                    return city;
                }
                set
                {
                    city = value;
                }
            }
            public string State
            {
                get
                {
                    return state;
                }
                set
                {
                    state = value;
                }
            }
            public string Zip
            {
                get
                {
                    return zip;
                }
                set
                {
                    zip = value;
                }
            }
            public string PhoneNumber
            {
                get
                {
                    return phoneNumber;
                }
                set
                {
                    phoneNumber = value;
                }
            }
            public string Email
            {
                get
                {
                    return email;
                }
                set
                {
                    email = value;
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