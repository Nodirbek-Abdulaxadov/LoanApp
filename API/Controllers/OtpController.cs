using Messager;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/otp")]
    [ApiController]
    public class OtpController : ControllerBase
    {
        private readonly IMessageService _messager;

        public OtpController(IMessageService messager)
        {
            _messager = messager;
        }

        [HttpPost("send/{phone}")]
        public async Task<IActionResult> SendAsync(string phone)
        {
            var result = await _messager.SendSMSAsync(phone);
            if (result.Success)
            {
                return Ok(result.Code);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
    }
}
