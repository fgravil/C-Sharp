using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heart_Rate_Calculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            HeartRates person = new HeartRates();

            Console.Write("Please enter your first name: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Please enter your birth year: ");
            person.BirthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the current year: ");
            person.CurrentYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nName: {0} {1}", person.FirstName, person.LastName);
            Console.WriteLine("Birth Year: {0}", person.BirthYear);

            int age = person.getAge();
            int maxHeartRate = person.getMaxHeartRate(age);
            double maxTarget = person.getMaxTargetRate(maxHeartRate);
            double minTarget = person.getMinTargetRate(maxHeartRate);

            Console.WriteLine("\nAge: {0}", age);
            Console.WriteLine("Maximum Heart Rate: {0}", maxHeartRate);
            Console.WriteLine("Maximum Target Heart Rate: {0}", maxTarget);
            Console.WriteLine("Minimum Target Heart Rate: {0}", minTarget);

            Console.ReadLine();
        }
    }

    
}

