namespace Test4AbstractionSalaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("John Doe");
            ContractEmployee contractEmployee = new ContractEmployee("Jane Doe");
            
            int workingHours = 40;
            Console.WriteLine($"Employee 1: {fullTimeEmployee.Name} - Salary: {fullTimeEmployee.CalculateSalary(workingHours):F1} lv.");
            Console.WriteLine($"Employee 2: {contractEmployee.Name} - Salary: {contractEmployee.CalculateSalary(workingHours):F1} lv.");

        }
    }
}
