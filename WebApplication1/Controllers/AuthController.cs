using AutoMapper;
using DemoWebApiApps.Services;
using System.Web.Http;

namespace DemoWebApiApps.Controllers
{
    //[ApiController]
    [Route("[controller]")]
    public class AuthController : ApiController
    {
        private readonly IUserAPIService _userApiService;
        private readonly IMapper _mapper;
        public AuthController(IUserAPIService userAPIService,IMapper mapper)
        {
            _userApiService=userAPIService;
            _mapper=mapper;
        }
        [Route("Login")]
        [HttpGet]
        public IHttpActionResult Index()
        {
           var res= _userApiService.GetAllUserList();
            return Ok(res);
        }
    }
}
