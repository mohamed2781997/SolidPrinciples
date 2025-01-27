using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciples;
public class CalculateSalaryEmployee
{

    public double CalculateSalary(Employee employee)
    {
        return employee.HoursWorked * employee.HourlyRate;
    }
}
