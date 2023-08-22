using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock_Test
{
    internal class Program
    {
        enum Menu
        {
            Read = 1, 
            Retirement, 
            Locality, 
            Search, 
            Exit
        }
        static void Main(string[] args)
        {
            bool cont = true;
            List<Employee> employees = new List<Employee>(); 
            
            while (cont == true)
            {
                Console.Clear();
                Console.WriteLine("1. Read");
                Console.WriteLine("2. View employees eligible for retirement ");
                Console.WriteLine("3. View local employees(SA)");
                Console.WriteLine("4. Search and display using the reference name");
                Console.WriteLine("5. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch ((Menu)choice)
                {
                    case Menu.Read:
                        AddEmployee(employees);
                        break;
                    case Menu.Retirement:
                        CheckRetirement(employees);
                        Console.ReadKey();
                        break;
                    case Menu.Locality:
                        CheckLocality(employees);
                        Console.ReadKey();
                        break;
                    case Menu.Search:
                        SearchEmployee(employees);
                        Console.ReadKey();
                        break;
                    case Menu.Exit:
                        cont = false;   
                        break;
                }
            }
        }
        static void AddEmployee(List<Employee> employees)
        {
            string Reference, LastName, FirstName, Country;
            int BirthYear;
            Console.Clear();
            Console.WriteLine("Enter Employee Reference Code:");
            Reference = Console.ReadLine();
            Console.WriteLine("Enter Employee Last Name:");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter Employee First Name:");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Employee Year of Birth");
            BirthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Country of Birth");
            Country = Console.ReadLine();
            Employee employee = new Employee(Reference, LastName, FirstName, BirthYear, Country);
            employees.Add(employee);
        }
        static void CheckRetirement(List<Employee> employees)
        {
            Console.Clear();
            Console.WriteLine("Employees that qualify for retirement: \n");
            int currentyear = DateTime.Now.Year;
            foreach (Employee employee in employees) 
            {
                int age = currentyear - employee.BirthYear1;
                if(age >= 60)
                {
                    Console.WriteLine(employee.ToString());
                }
            }

        }
        static void CheckLocality(List<Employee> employees)
        {
            Console.Clear();
            Console.WriteLine("Employees born in South Africa: \n");
            foreach (Employee employee in employees)
            {
                if (employee.Country1.ToUpper() == "SA")
                {
                    Console.WriteLine(employee.ToString());
                }
            }

        }
        static void SearchEmployee(List<Employee> employees)
        {
            bool found = false;
            Console.Clear();
            Console.WriteLine("Enter employee reference code: ");
            string code = Console.ReadLine();
            foreach (Employee employee in employees)
            {
                if (code.ToUpper() == employee.Reference1)
                {
                    found = true;
                    Console.WriteLine("Found Employee: ");
                    Console.WriteLine(employee.ToString());
                    break;
                }
            }    
            if(found == false)
            {
                Console.WriteLine("Employee with code: \"{0}\", is not present in the system", code);
            }

        }
    }
}
