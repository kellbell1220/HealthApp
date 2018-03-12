using System;
using static System.Console;

namespace HealthProfileApp
{
    class Patient
    {
        private String firstName;
        private String lastName;
        private String gender;
        private double height;
        private double weight;
        private int birthYear;
        private int birthMonth;
        private int birthDay;
        private int currentYear;

        public Patient()
        {

        }

        public Patient(String firstName, String lastName, String gender, double height, double weight, int birthYear, int currentYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.height = height;
            this.weight = weight;
            this.birthYear = birthYear;
            this.currentYear = currentYear;
        }

        public Patient(String firstName, String lastName, String gender, double height, double weight, int birthYear, int birthMonth, int birthDay, int currentYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.height = height;
            this.weight = weight;
            this.birthYear = birthYear;
            this.birthMonth = birthMonth;
            this.birthDay = birthDay;
            this.currentYear = currentYear;
        }

        //Getter and Setters for all of my properties
        public String FirstName
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
        public String LastName
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
        public String Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public int BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                birthYear = value;
            }
        }
        public int BirthMonth
        {
            get
            {
                return birthMonth;
            }
            set
            {
                birthMonth = value;
            }
        }
        public int BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                birthDay = value;
            }
        }
        public int CurrentYear
        {
            get
            {
                return currentYear;
            }
            set
            {
                currentYear = value;
            }
        }

        //How old is your patient
        public int PatientsAge()
        {
            return CurrentYear - BirthYear;
        }

        //Max heart rate
        public int MaxHeartRate()
        {
            return 220 - PatientsAge();
        }

        //Target heart rate min
        public double MinTargetHeartRate()
        {
            return MaxHeartRate() * .5;
        }

        //Target heart rate max
        public double MaxTargetHeartRate()
        {
            return MaxHeartRate() * .85;
        }

        //BMI
        public double PatientBMI()
        {
            return (Weight * .45) / ((Height * .025) * (Height * .025));
        }

        public override string ToString()
        {
            return ("\n\tHEALTH PROFILE FOR: " + FirstName + " " + LastName + "\nGender: \t\t"
                + Gender + "\nAge: \t\t\t" + PatientsAge() + "\nHeight (inches): \t"
                + Height + "\nWeight (pounds): \t" + Weight + "\nMaximum Heart Rate: \t"
                + MaxHeartRate() + "\n\n\tTARGET HEART RATE RANGE\nMinimum: \t" + MinTargetHeartRate().ToString("F2")
                + "\nMaximum: \t" + MaxTargetHeartRate().ToString("F2") + "\n\n\tYOUR PATIENT'S BMI\nBMI: \t" + PatientBMI().ToString("F2") + "\n\n\tEVALUATE BMI RANGE\n"
                + "Underweight:\tLess Than 18.5\nNormal:\t\tBetween 18.5 And 24.9\nOverweight:\tBetween 25 And 29.9\n"
                + "Obese:\t\t30 Or Greater\n");
        }
    }

}

