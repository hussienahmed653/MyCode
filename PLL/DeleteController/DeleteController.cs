using _3_Layer_architecture.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3_Layer_architecture.PLL.DeleteController
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteController : ControllerBase
    {
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            DeleteEmp emp = new DeleteEmp();
            emp.deleteemp(id);
            return Ok();
        }
    }
}
