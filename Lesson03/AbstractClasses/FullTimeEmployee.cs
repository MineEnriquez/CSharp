using System;

public class FullTimeEmployee : BaseEmployee
{
    
    public int AnnualSalary {get; set; }

    //We need to make this method an override of the BaseEmployee one.
     public override int GetMonthlySalary(){
        return this.AnnualSalary / 12;
    }
}