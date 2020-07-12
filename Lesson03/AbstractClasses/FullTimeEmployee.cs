using System;

public class FullTimeEmployee : BaseEmployee
{
    
    public int AnnualSalary {get; set; }
     public int GetMonthlySalary(){
        return this.AnnualSalary / 12;
    }
}