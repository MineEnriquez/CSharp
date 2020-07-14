using System;

public class ContractEmployee : BaseEmployee
{
    public int HourlyPay {get; set;}
    public int TotalHours {get; set;}

    //We need to make this method an override of the BaseEmployee one.
    public override int GetMonthlySalary(){
        return this.HourlyPay * this.TotalHours;
    }
}