using System;

namespace number_7
{
    public class Employee
{
    string name;
    string surname;
    DateTime dateOfHire;
    double salary;

    public enum Position
    {
        Slave = 10000,
        Warden = 100000,
        Lord = 1000000
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime DateOfHire
    {
        get
        {
            return dateOfHire;
        }
        set
        {
            if (dateOfHire.Date < DateTime.Parse("01.01.1995"))
            {
                dateOfHire = value;
            }
            else
            {
                Console.WriteLine("Date before times!");
            }

        }
    }

    public Employee(string name, string surname, DateTime dateOfHire)
    {
        Name = name;
        Surname = surname;
        DateOfHire = dateOfHire;
    }

    public double DiscoverGrade(DateTime dateOfHire)
   
    {
        double dateValueForGrade = (DateTime.Now - dateOfHire).TotalDays;

        if (dateValueForGrade >= 1825 && dateValueForGrade < 3650)
            return 1.5;
        else if (dateValueForGrade >= 3650)
            return 1.25;
        else
            return 1.0;
    }

    public double Calculation(Position position)
   
    {
        double grade = DiscoverGrade(dateOfHire);
        switch (position)
        {
            case Position.Slave:
                salary = 10000 * grade;
                return salary;
            case Position.Warden:
                salary = 100000 * grade;
                return salary;
            case Position.Lord:
                salary = 1000000 * grade;
                return salary;
            default:
                Console.WriteLine("No such position!");
                break;

        }
        return 0.0;
    }
} 
}
class Program
{
    static void Main(string[] args)
    {
        Employee one = new Employee("Anton", "Lupanov", DateTime.Parse("01.02.2000"));
        Console.WriteLine("Name is {0}, surname is {1}. Date of hire: {2}", one.Name, one.Surname, one.DateOfHire);
        double salary = one.Calculation(Employee.Position.Lord);
        Console.WriteLine("Salary is {0}, tax is {1}, position is {2}.", salary, salary * 0.34, Employee.Position.Lord);
    }
}
