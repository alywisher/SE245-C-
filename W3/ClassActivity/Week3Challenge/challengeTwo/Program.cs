using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a method called reverse string, main method should reverse the string passing a string to be reversed 
//print out the string before and after 
namespace WeekThreeChallengeTwo{
    class Program{
        static void MainMethod(string text)
        {
            Console.WriteLine("Input: "+text);
            Console.Write("Output: ");
            for (int i = text.Length - 1; i >= 0; i--) //tis work kinda
            {
                Console.Write(text[i]);
               
            }
        }
        static void Main(string[] args)
        {
            MainMethod("Hello"); //For fuck sake STOP
        }

        
    }
}