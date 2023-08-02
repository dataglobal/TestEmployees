using BLL;

namespace TestProject_Employees
{
    public class TestEmployees
    {
        private BLLEmployees _employees;
        [SetUp]
        public void Setup()
        {
            _employees = new BLLEmployees();
        }

        [Test]
        public void Test1()
        {
            var result = _employees.GetEmployeesById(1);
            Assert.That(result, !Is.Empty);
        }
    }
}