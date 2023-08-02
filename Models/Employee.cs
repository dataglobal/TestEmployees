namespace Models
{
    public class Employee
    {
        public Employee() { }
        public int Id { get; set; }
        public string? EmployeeName { get; set; }
        public decimal EmployeeSalary { get; set; }
        public int EmployeeAge { get; set; }
        public string? ProfileImage { get; set; }
        // Calculate Field
        public decimal AnualSalary { get; set; }
    }
}
