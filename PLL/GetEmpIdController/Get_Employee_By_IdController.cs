using _3_Layer_architecture.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3_Layer_architecture.PLL.GetEmpIdController
{
    [Route("api/[controller]")]
    [ApiController]
    public class Get_Employee_By_IdController : ControllerBase
    {
        ImplentEmp emp = new ImplentEmp();
        [HttpGet]
        public IActionResult GetEmployee(int? id)
        {
            if(id is null)
                return Ok(emp.GetEmployees());
            return Ok(emp.GetEmployees(id));
        }
    }
}
