using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Payment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult GetPayment()
        {
            _logger.LogError("Test ERRO log.");
            return Ok();
        }
    }
}
