using _3_Layer_architecture.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3_Layer_architecture.PLL.GetEmpIdController
{
    [Route("api/[controller]")]
    [ApiController]
    public class Get_EmployeeController : ControllerBase
    {
        ImplentEmp emp = new ImplentEmp();
        [HttpGet]
        public IActionResult GetEmployee()
        { 
            return Ok(emp.GetEmployees(null));
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int? id)
        { 
            return Ok(emp.GetEmployees(id));
        }
    }
}
