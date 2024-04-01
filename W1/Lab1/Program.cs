using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Calculate payroll with Name, hour, hourly rate, along with taxes deducted based on tax bracket. test


namespace Week1_Lab1 {
    class Program {
        static void Main (string[] args){
            String strFirst, strHour, strHourRate, strGross;
            Int32 intHour = 0, intHourRate = 0, intTax = 0, intGross = 0;
            Double dblResult;

            Console.WriteLine ("Welcome to the Pay Coulculator!");

            Console.WriteLine ("Please enter your Firts Name: ");
            strFirst = Console.ReadLine ();

            Console.WriteLine ("Welcome " + strFirst + ", lets start couculating your wages!" );

            Console.WriteLine ("Please enter the hours you worked: ");
            strHour = Console.ReadLine ();

            Console.WriteLine ("Now, enter your Hourly Rate: ");
            strHourRate = Console.ReadLine ();

            intGross = Int32.Parse (strGross);
            intHour = Int32.Parse (strHour);
            intHourRate = Int32.Parse (strHourRate);

            intGross = intHour * intHourRate

            if (intGross < 100 )
                intTax = 0.0
            else if (intGross < 500)
                intTax = 0.2
            else if (intGross < 1000)
                intTax = 0.3
            else
                intTax = 0.5
            
            Console.WriteLine ("Based on your information provided your")
            //gross = HourRate * rate
            //tax = gross * taxRate
            //net = gross - tax
            //net = gross * (1.0 - taxRate) -> two diff ways




        }
}
}
