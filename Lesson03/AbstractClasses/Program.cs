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
            Console.WriteLine(fte.GetMonthlySalary());

        ContractEmployee cte = new ContractEmployee(){
            ID  = 102,
                FirstName = "some",
                LastName = "here",
                HourlyPay = 20,
                TotalHours = 40
        };
        Console.WriteLine(cte.GetFullName());
        Console.WriteLine(cte.GetMonthlySalary());
        }
    }
}
