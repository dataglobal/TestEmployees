using Models;
using DAL;
namespace BLL
{
    public class BLLEmployees
    {
        DALEmployees employees = new DALEmployees();
        public BLLEmployees() { }
        public List<Employee> GetEmployeesWithAnualSalary() {
            List<Employee> list = employees.GetEmployeesAll();
            List<Employee> newList = new List<Employee>();
            foreach (Employee emp in list)
            {
                emp.AnualSalary = emp.EmployeeSalary * 12;
                newList.Add(emp);
            }
            return newList;
        }
        public List<Employee> GetEmployeesAll() {           
            return employees.GetEmployeesAll();
        }
        public List<Employee> GetEmployeesById(int Id)
        {
            Employee employee = employees.GetEmployeesById(Id);
            List<Employee> newList = new List<Employee>();
            employee.AnualSalary = employee.EmployeeSalary*12;
            newList.Add((Employee) employee);
            return newList;
        }        
    }
}