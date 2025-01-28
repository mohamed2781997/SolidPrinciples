
using SolidPrinciples.LiskovSubstitutionPrinciple;
using SolidPrinciples.OpenClosedPrinciples;
using SolidPrinciples.SingleResponsibilityPrinciples;
using System.Diagnostics.Metrics;
namespace SolidPrinciples
{
    public  class Program
    {
        static void Main(string[] args)
        {

            #region Interface Segeregation
            var employees = Before.Repository.LoadEmployees();

            foreach (var e in employees)
            {
                Console.WriteLine(e.PrintSalarySlip());
                Console.WriteLine();
            }



            Console.WriteLine("====================================After implement isp================================");


            var employeess = After.Repository.LoadEmployees();

            foreach (var e in employeess)
            {
                Console.WriteLine(e.PrintSalarySlip());
                Console.WriteLine();
            }
            Console.ReadKey();
            #endregion


            #region SingleResponsibility
            //Employee employee = new Employee("John Doe", 160, 25);

            //CalculateSalaryEmployee calculateSalaryEmployee = new CalculateSalaryEmployee();


            //EmployeeReport report = new EmployeeReport();
            //report.Print(employee, calculateSalaryEmployee);


            //EmployeeDatabase database = new EmployeeDatabase();
            //database.Save(employee);
            #endregion

            #region OpenClosedPrinciples
            //Product product1 = new Product("Electronics", 1000);
            //Product product2 = new Product("Clothing", 500);

            //DiscountCalculator discountCalculator1 = new DiscountCalculator(new ElectronicsDiscount());
            //DiscountCalculator discountCalculator2 = new DiscountCalculator(new ClothingDiscount());

            //Console.WriteLine($"Electronics Discount: {discountCalculator1.GetDiscount(product1)}");
            //Console.WriteLine($"Clothing Discount: {discountCalculator2.GetDiscount(product2)}");
            #endregion


            #region Liskov
            //Shape rectangle = new Rectangle(5, 10);
            //Shape square = new Square(5);

            //Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
            //Console.WriteLine($"Square Area: {square.Area()}");


            //var account = new Before.FixedDepositAccount("Issam", 10_000);
            //account.Withdraw(1000);

            //var account = new After.CheckingAccount("Issam", 10_000);
            //account.Withdraw(1000);

            //var account = new After.FixedDepositAccount("Issam", 10_000);
            //account.Withdraw(1000); // won't work
            Console.ReadKey();
            #endregion


        }

    }

}
