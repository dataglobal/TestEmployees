using BLL;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Text.Encodings.Web;

namespace ModuloEmpleados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        BLLEmployees employee = new BLLEmployees();

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            List<Employee> _listEmployees = employee.GetEmployeesAll();
            return Ok(_listEmployees);
        }
        [HttpGet("with-salary")]
        public IActionResult GetEmployeesWithAnualSalary()
        {
            List<Employee> _listEmployees = employee.GetEmployeesWithAnualSalary();
            return Ok(_listEmployees);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            List<Employee> _listEmployees = employee.GetEmployeesById(Id);
            return Ok(_listEmployees[0].Id==0? "Sin datos": _listEmployees);
        }

    }
}
