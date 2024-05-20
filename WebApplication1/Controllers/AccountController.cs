using DemoWebApiApps.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IUserAPIService _userApiService;
        public AccountController(IUserAPIService userAPIService)
        {
            _userApiService = userAPIService;
        }
        //[Route("Login")]
        [HttpGet(Name = "Login")]
        public async Task<IActionResult> Index()
        {
            var res = _userApiService.GetAllUserList();
            return Ok(res);
        }
    }
}
