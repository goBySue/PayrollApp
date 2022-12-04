using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollPractice
{
    internal class Employee
    {
        private string empLname;
        private string empFname;
        private int noOfDependetns;
        private double noOfHours;

        public Employee()
            // Default constructor
        {

        }

        public Employee(string last, string first, int dep, double hours)
        {
            empLname= last;
            empFname= first;
            noOfDependetns= dep;
            noOfHours= hours;
        }

        public Employee(string last, string first)
        {
            empLname= last;
            empFname= first;
        }

        public Employee(string last, string first, int dep)
        {
            empLname = last;
            empFname = first;
            noOfDependetns = dep;
        }
        // Properties for each field
        public string EmpLname
        {
            get { return empLname; }
            set { empLname = value; }
        } 
        public string FName
        {
            get { return empFname; }
            set { empFname = value; }
        }

        public double DetermineGross()
        {
            const double RATE = 150.00; 

            return RATE * noOfHours;
        }

        public double DetermineAgencyFee()
        {
            const double AGENCY_CHARGE = 0.13;
            return DetermineGross() * AGENCY_CHARGE;
        }

        public double DetermineFederalTax()
        {
            const double FEDERAL_TAX = 0.25;
            const double DEPENDENTS_ALLOWANCE = 0.0575;
            double gross;

            gross = DetermineGross();

           
            return (gross - ( gross * (DEPENDENTS_ALLOWANCE * noOfDependetns))) * FEDERAL_TAX;
        }

        public double SocialSecurity()
        {
            const double SOCIAL_SECURITY_RATE = 0.0785;
            return DetermineGross() * SOCIAL_SECURITY_RATE;
        }

        public double DetermineNet()
        {
            return DetermineGross() - SocialSecurity() - DetermineFederalTax() - DetermineAgencyFee();
        }

        public override string ToString()
        {
            return empFname + " " + empLname +
                " Take Home Pay: " + DetermineNet().ToString("C");
        }
    }
}
 