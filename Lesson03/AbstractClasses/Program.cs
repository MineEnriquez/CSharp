using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Mine",    
                LastName = "Quiquez",
                AnnualSalary = 120
            };
            Console.WriteLine(fte.GetFullName());
            Console.WriteLine("Salary: " + fte.GetMonthlySalary());

        ContractEmployee cte = new ContractEmployee(){
            ID  = 102,
                FirstName = "John",
                LastName = "Doe",
                HourlyPay = 20,
                TotalHours = 40
        };
        Console.WriteLine(cte.GetFullName());
        Console.WriteLine("Salary: " + cte.GetMonthlySalary());
        }
    }
}
