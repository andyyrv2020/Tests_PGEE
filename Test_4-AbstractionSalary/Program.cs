namespace Test_4_AbstractionSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseEmployee employee1 = new FullTimeEmployee("John");
            BaseEmployee employee2 = new ContractEmployee("Jane");

            int workingHours = 160;

            Console.WriteLine("Employee 1: " + employee1.Name + " Salary: " + employee1.CalculateSalary(workingHours));
            Console.WriteLine("Employee 2: " + employee2.Name + " Salary: " + employee2.CalculateSalary(workingHours));
        }
    }
}
