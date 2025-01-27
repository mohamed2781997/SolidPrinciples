using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciples;
public class EmployeeReport
{
    public void Print(Employee employee, CalculateSalaryEmployee calculateSalaryEmplyee)
    {
        Console.WriteLine($"Employee: {employee.Name}, Salary: {calculateSalaryEmplyee.CalculateSalary(employee)}");
    }
}
