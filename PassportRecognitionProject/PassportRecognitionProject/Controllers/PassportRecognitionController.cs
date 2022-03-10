using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PassportRecognitionProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PassportRecognitionController : ControllerBase
    {

        private readonly ILogger<PassportRecognitionController> _logger;

        public PassportRecognitionController(ILogger<PassportRecognitionController> logger)
        {
            _logger = logger;
        }
    }
}
