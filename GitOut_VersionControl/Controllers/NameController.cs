using Microsoft.AspNetCore.Mvc;

namespace GitOut_VersionControl.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
       

        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new { name = "Jake Childs" });
        }
    }
}
