using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoRoleApi.Controllers
{
    [Authorize("DevelopperRequired")]
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopperController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            yield return "Developper Info 1";
            yield return "Developper Info 2";
            yield return "Developper Info 3";
            yield return "Developper Info 4";
        }
    }
}
