using CRUD_Operations.Data;
using CRUD_Operations.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Operations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDataController : ControllerBase
    {
        private readonly DBApplication dbContext;

        public EmployeeDataController(DBApplication dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var allEmployees= dbContext.Employees.ToList();
            return Ok(allEmployees);
        }
        [HttpGet]
        [Route("{id:guid}")]

        public IActionResult GetEmployeeByID(Guid id)
        {
            var Employee = dbContext.Employees.Find(id);
            if (Employee is null)
            {
                return NotFound();
            }
            return Ok(Employee);

        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDetails addEmployeeDetails)
        {
            var employeentity = new Employee()
            {
                Name = addEmployeeDetails.Name,
                Email = addEmployeeDetails.Email,
                PhoneNumber = addEmployeeDetails.PhoneNumber,
                Salary = addEmployeeDetails.Salary
            };

            dbContext.Employees.Add(employeentity);
            dbContext.SaveChanges();

            return Ok(employeentity);


        }
        [HttpPut]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDetails updateEmployeeDetails)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            employee.Name = updateEmployeeDetails.Name;
            employee.Email = updateEmployeeDetails.Email;
            employee.PhoneNumber = updateEmployeeDetails.PhoneNumber;
            employee.Salary = updateEmployeeDetails.Salary;

            dbContext.SaveChanges();

            return Ok(employee);
        }
        [HttpDelete]
        [Route("{id:guid}")]

        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();

            return Ok(employee);


        }



    }
}
