using System;

public class ContractEmployee : BaseEmployee
{
    public int HourlyPay {get; set;}
    public int TotalHours {get; set;}
    public int GetMonthlySalary(){
        return this.HourlyPay * this.TotalHours;
    }
}