using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciples;
public class Employee
{
    //Notes
    /*  1.That I want to apply single responsibity Principle 
          does not mean that I should create a class for each method.
          This is the biggest mistake. I can call a method that performs a specific action,
          but I do not have to do it for every method class */
    public string Name { get; set; }
    public double HoursWorked { get; set; }
    public double HourlyRate { get; set; }

    public Employee(string name, double hoursWorked, double hourlyRate)
    {
        Name = name;
        HoursWorked = hoursWorked;
        HourlyRate = hourlyRate;
    }
    

}
