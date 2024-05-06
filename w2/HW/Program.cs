using System;
//Asks users to enter a number of students, or handle the number of students dynamically.
// For each student, enter a name and 5 lab grades. 
// Display each student with each average grade for their 5 labs, and their letter grade. 
//Drop down a line or two, and then display the average for each lab #.  (Average grade on Lab #1 for all students)
namespace week2Lab
{
    class Project
    {
        //empty lists????

        //vars
        //choice -> used for the while loop
        //studName -> to get student name
        //lab1 -> lab 1 grade
        //lab2 -> lab 2 garde
        //lab3 -> lab 3 grade
        //lab4 -> lab 4 grade
        //lab5 -> lab 5 grade
        //avgLabGrade -> for the ducking avrage 
        String studName, choice, letterGrade;
        Int lab1Grade = 0, lab2Grade = 0, lab3Grade = 0, lab4Grade = 0, lab5Grade = 0, avgLabGrade = 0, amountOfStudents = 0;
        static void Main(string[] args)
        {
            
            Console.Write("Welcome to the Student Grading Program! Would you like to begin entering in students [Y/N]: ");
            choice = Console.ReadLine();
            
            while( choice = "Y")
            {
                Console.Write("How many students would you like to enter: ");
                amountOfStudents = Console.ReadLine();
                //another loop?
                while(amountOfStudents >= 5 )
                {
                    //get the name of the students one at a time
                    Console.Write("\nWhat is the name of your student: ");
                    Console.ReadLine();
                    //get the labs of eatch student 
                    Console.Write("\nPlease enter the score for Lab 1: ");
                    lab1Grade = Console.ReadLine();

                    Console.Write("\nPlaase enter the score for lab 2: ");
                    lab2Grade = Console.ReadLine();

                    Console.Write("\nPlaase enter the score for lab 3: ");
                    lab3Grade = Console.ReadLine();

                    Console.Write("\nPlaase enter the score for lab 4: ");
                    lab4Grade = Console.ReadLine();

                    Console.Write("\nPlaase enter the score for lab 5: ");
                    lab5Grade = Console.ReadLine();
                    //Display avrage lab grade
                    Console.Write($"\nThe avrage Lab grade for {studName} is: ");
                    Console.ReadLine();

                    Console.Write("\nWould you like to enter another student [Y/N]: ");
                    choice = Console.ReadLine();
                }
                    
            }
            //calc avg
            avgLabGrade = lab1Grade + lab2Grade + lab3Grade + lab4Grade + lab5Grade / 5;
            //if statement to run through in order to get the letter grade
            if(avgLabGrade >= 90 && avgLabGrade <= 100)
            {
                letterGrade = Console.Write("A");
            }
            else if(avgLabGrade >= 80 && avgLabGrade <= 90)
            {
                letterGrade = Console.Write("B");
            }
            else if(avgLabGrade >= 70 && avgLabGrade <= 80)
            {
                letterGrade = Console.Write("C");
            }
            else if(avgLabGrade >= 60 && avgLabGrade <= 70)
            {
                letterGrade = Console.Write("D");
            }
            else(avgLabGrade <= 70);
            {
                letterGrade = Console.Write("F"); 
            }

            //final display
            Console.Write("\n----------------------------------------------------"); //this ending shit may have to be another loopers doopers
            Console.Write($"Here is the the information you have given: ");
            Console.Write("----------------------------------------------------");
            Console.Write($"\n")


            //me will to live is shrinking 
            
        }


    }
}