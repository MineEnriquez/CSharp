using System;

public abstract class BaseEmployee
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string GetFullName()
    {
        return this.FirstName + this.LastName;
    }

    // Marking it as virtual method because the BaseEmployee class doesn't know how will the FTE and ContractEmployee will actually be implementing it.
    public virtual int GetMonthlySalary()  
    {
        throw new NotImplementedException();
    }
}