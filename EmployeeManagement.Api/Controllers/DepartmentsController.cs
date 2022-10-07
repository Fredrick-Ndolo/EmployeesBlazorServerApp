using EmployeeManagement.Api.Models;
using Employees.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;
        public DepartmentsController(IDepartmentRepository _departmentRepository)
        {
            this.departmentRepository = _departmentRepository;
        }
        // GET: api/<DepartmentsController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                return Ok(await departmentRepository.GetDepartments());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }

        }

        // GET api/<DepartmentsController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                return Ok(await departmentRepository.GetDepartment(id));
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,"Error retrieving data from the database");
            }
        }

        //// POST api/<DepartmentsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<DepartmentsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<DepartmentsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
