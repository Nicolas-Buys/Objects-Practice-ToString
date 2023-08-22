using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock_Test
{
    internal class Employee
    {
        private string Reference, LastName, FirstName, Country;
        private int BirthYear;

        public Employee(string reference, string lastName, string firstName, int birthYear, string country)
        {
            Reference1 = reference;
            LastName1 = lastName;
            FirstName1 = firstName;
            Country1 = country;
            BirthYear1 = birthYear;
        }

        public string Reference1 { get => Reference; set => Reference = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string Country1 { get => Country; set => Country = value; }
        public int BirthYear1 { get => BirthYear; set => BirthYear = value; }

        public override string ToString()
        {
            //return string.Format("Reference Code: {0}\nLast Name: {1}\nFirst Name: {2}\nBirth Year: " +
            //    "{3}\nCountry of Birth: {4}\n", Reference, LastName, FirstName, BirthYear, Country);
            return "Reference Code: " + Reference + " \nLast Name: " + LastName + "\nFirst Name: " + FirstName +
                "\nBirth Year: " + BirthYear + "\nCountry of Birth: "+ Country+"\n";
        }
    }
}
