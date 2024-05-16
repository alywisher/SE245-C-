using System;
//Lab Assign#3: Convert week 2 lab to utilize Methods (Void / Return / By Ref)
//For each student, enter a name and 5 lab grades.  Display each student with each average grade for their 5 labs, and their letter grade.  Drop down a line or two, and then display the average for each lab #.  (Average grade on Lab #1 for all students)
namespace week3Lab
{
    class Project
    {
        string studName, choice, letterGrade;
        int lab1Grade = 0, lab2Grade = 0, lab3Grade = 0, lab4Grade = 0, lab5Grade = 0, avgLabGrade = 0, amountOfStudents = 0; 
        static void Main(string[] args)
        {
            List<string> studentName = new List<string>();
            List<double> studLab = new List<double>();
            List<double> studLab2 = new List<double>();
            List<double> studLab3 = new List<double>();
            List<double> studLab4 = new List<double>();
            List<double> studLab5 = new List<double>();
            List<double> studAvgLab = new List<double>();
            List<string> studLetterGrade = new List<string>();

            Console.Write("Welcome to the Student Grading Program! Would you like to begin entering in students [Y/N]: ");
            string choice = Console.ReadLine();
            
            if( choice == "Y")
            {
                Console.Write("How many students would you like to enter: ");
                int amountOfStudents = int.Parse(Console.ReadLine());
                int counter = 1;
                while(counter <= amountOfStudents )
                {
                    Console.Write("\nWhat is the name of your student: ");
                    string studName = Console.ReadLine();
                    studentName.Add(studName);

                    Console.Write("\nPlease enter the score for Lab 1: ");
                    double lab1Grade = double.Parse(Console.ReadLine());
                    studLab.Add(lab1Grade);

                    Console.Write("\nPlaase enter the score for lab 2: ");
                    double lab2Grade = double.Parse(Console.ReadLine());
                    studLab2.Add(lab2Grade);

                    Console.Write("\nPlaase enter the score for lab 3: ");
                    double lab3Grade = double.Parse(Console.ReadLine());
                    studLab3.Add(lab3Grade);

                    Console.Write("\nPlaase enter the score for lab 4: ");
                    double lab4Grade = double.Parse(Console.ReadLine());
                    studLab4.Add(lab4Grade);

                    Console.Write("\nPlaase enter the score for lab 5: ");
                    double lab5Grade = double.Parse(Console.ReadLine());
                    studLab5.Add(lab5Grade);

                    double avgLabGrade = (lab1Grade + lab2Grade + lab3Grade + lab4Grade + lab5Grade) / 5;
                    studAvgLab.Add(avgLabGrade);
                    
                    string letterGrade;
                    if(avgLabGrade >= 90 && avgLabGrade <= 100)
                    {
                        letterGrade = "A";
                    }
                    else if(avgLabGrade >= 80 && avgLabGrade <= 90)
                    {
                        letterGrade = "B";
                    }
                    else if(avgLabGrade >= 70 && avgLabGrade <= 80)
                    {
                        letterGrade = "C";
                     }
                     else if(avgLabGrade >= 60 && avgLabGrade <= 70)
                     {
                        letterGrade = "D";
                     }
                     else
                     {
                        letterGrade ="F"; 
                     }
                     studLetterGrade.Add(letterGrade);

                    Console.Write("\n----------------------------------------------------");
                    Console.Write($"Here is the Students information");
                    Console.Write("----------------------------------------------------");
                    Console.WriteLine($"\nStudent Name: {studName} ");
                    Console.WriteLine($"Student Avg. Grade: {avgLabGrade} ");
                    Console.WriteLine($"Student Avg. Letter Grade: {letterGrade}");
                    Console.Write("-----------------------------------------------------------------------------------------------------------------------------------------");
                    counter++;
                }
                    
            }
            
        }


    }
}
