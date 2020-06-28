using System;

public abstract class BaseEmployee
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string GetFullName()
    {
        return this.FirstName + " " + this.LastName;
    }

    // By marking GetMonthlySalary as ABSTRACT method we don't have to provide an implementation  
    // but instead only a declaration.
    public abstract int GetMonthlySalary();
    
}