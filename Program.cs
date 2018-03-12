using System;
using static System.Console;

namespace HealthProfileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\tHEALTH PROFILE APPLICATION\n");
            Patient patient1 = new Patient();
            patient1.FirstName = AskPatientsName("First");
            patient1.LastName = AskPatientsName("Last");
            patient1.Gender = AskPatientsGender();
            patient1.Height = AskPatientsHeight();
            patient1.Weight = AskPatientsWeight();
            patient1.BirthYear = AskPatientsDOB();
            patient1.CurrentYear = AskCurrentYear();

            Write(patient1.ToString());

            ReadKey();

        }

        //Asking for patient's first and last name
        static String AskPatientsName(String whichOne)
        {
            Write("Enter {0} Name: ", whichOne);
            String inValue = ReadLine();

            return inValue;
        }

        //Asking for patient's gender
        static String AskPatientsGender()
        {
            Write("Enter Gender: ");
            String inValue = ReadLine();

            return inValue;
        }

        //Asking for patient's height
        static double AskPatientsHeight()
        {
            Write("Enter Height In Inches: ");
            String inValue = ReadLine();

            return double.Parse(inValue);
        }

        //Asking for patient's weight
        static double AskPatientsWeight()
        {
            Write("Enter Weight In Pounds: ");
            String inValue = ReadLine();

            return double.Parse(inValue);
        }

        //Asking for patient's year of birth
        static int AskPatientsDOB()
        {
            Write("Enter Year Of Birth (etc. 1955): ");
            String inValue = ReadLine();

            return int.Parse(inValue);
        }

        //Asking for current year
        static int AskCurrentYear()
        {
            Write("Enter Current Year: ");
            String inValue = ReadLine();

            return int.Parse(inValue);
        }
    }      
}
