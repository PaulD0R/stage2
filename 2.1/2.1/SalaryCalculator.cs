namespace _2._1;

public static class SalaryCalculator
{
    public static double GetSalary(Employee employee)
    {
        return Math.Round(employee.TimeWork * employee.HourlyRate, 2);
    }
}