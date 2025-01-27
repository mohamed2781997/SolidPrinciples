using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciples;
internal class EmployeeDatabase
{
    public void Save(Employee employee)
    {
        Console.WriteLine($"Saving {employee.Name} data to the database...");
    }
}
