using _3_Layer_architecture.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3_Layer_architecture.PLL.UpdateController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateController : ControllerBase
    {
        [HttpPost]
        public IActionResult Updateemp(int id, string? fname, string? lname, string? email, string? address,int? salary_id, int? dept_id)
        {
            Update update = new Update();
            update.UPDATE(id,fname,lname,email,address,salary_id, dept_id);
            return Ok();
        }
    }
}
