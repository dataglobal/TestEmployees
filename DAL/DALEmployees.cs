using Models;
namespace DAL
{
    public class DALEmployees
    {
        List<Employee> list = new List<Employee>();
        public DALEmployees() {
            list.Add(new Employee()
            {
                Id = 1,
                EmployeeName = "Tiger Nixon",
                EmployeeSalary = 100,
                EmployeeAge = 25,
                ProfileImage = ""
            });
            list.Add(new Employee()
            {
                Id = 2,
                EmployeeName = "Garrett Winters",
                EmployeeSalary = 200,
                EmployeeAge = 45,
                ProfileImage = ""
            });
            list.Add(new Employee()
            {
                Id = 3,
                EmployeeName = "Ashton Cox",
                EmployeeSalary = 300,
                EmployeeAge = 18,
                ProfileImage = ""
            });
            list.Add(new Employee()
            {
                Id = 4,
                EmployeeName = "Cedric Kelly",
                EmployeeSalary = 400,
                EmployeeAge = 23,
                ProfileImage = ""
            });

            list.Add(new Employee()
            {
                Id = 5,
                EmployeeName = "Airi Satou",
                EmployeeSalary = 500,
                EmployeeAge = 94,
                ProfileImage = ""
            });

            list.Add(new Employee()
            {
                Id = 6,
                EmployeeName = "Brielle Williamson",
                EmployeeSalary = 600,
                EmployeeAge = 32,
                ProfileImage = ""
            });

        }
        public List<Employee> GetEmployeesAll()
        {   
            return list;
        }

        public Employee GetEmployeesById(int Id)
        {
            List<Employee> filteredResult = list.FindAll(employee => employee.Id == Id);
            Employee employee1 = new Employee();
            if (filteredResult.Count>0)
            {
                employee1 = filteredResult[0];
            }
            return employee1;
        }
    }
}