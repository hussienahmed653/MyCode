using _3_Layer_architecture.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3_Layer_architecture.PLL.InsertController
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsertController : ControllerBase
    {
        [HttpPut]
        public IActionResult Insert(string fname, string lname, string email, int address, int dept_id)
        {
            InsertValues insertValues = new InsertValues();
            insertValues.Insertvalues(fname, lname, email, address, dept_id);
            return Ok();
        }
    }
}
