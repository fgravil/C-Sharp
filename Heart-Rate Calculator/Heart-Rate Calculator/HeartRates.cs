using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heart_Rate_Calculator
{
    public class HeartRates
    {
        private string firstName;
        private string lastName;
        private int birthYear;
        private int currentYear;

        public HeartRates()
        {

        }
        public HeartRates(string firstName,string lastName,int birthYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
        }
        public int getAge()
        {
            return currentYear - birthYear;
        }
        public int getMaxHeartRate(int age)
        {
            return 220 - age;
        }
        public double getMinTargetRate(int maxRate)
        {
            return maxRate * .5;
        }
        public double getMaxTargetRate(int maxRate)
        {
            return maxRate * .85;
        }
        public string FirstName
        {
            set{
                firstName = value;
            }
            get{
                return firstName;
            }
        }
        public string LastName
        {
            set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }
        public int BirthYear
        {
            set
            {
                birthYear = value;
            }
            get
            {
                return birthYear;
            }
        }
        public int CurrentYear
        {
            set
            {
                currentYear = value;
            }
            get
            {
                return currentYear;
            }
        }

    }
}
