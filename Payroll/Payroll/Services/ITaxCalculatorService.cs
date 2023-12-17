namespace Payroll.Services
{
    public interface ITaxCalculatorService
    {
        string GetFullName(string firstName, string lastName);
        decimal CalculateGrossIncome(decimal annualSalary);
        decimal CalculateIncomeTax(decimal annualSalary);
        decimal CalculateNetIncome(decimal grossIncome, decimal incomeTax);
        decimal CalculateSuper(decimal grossIncome, decimal superRate);
    }
}
