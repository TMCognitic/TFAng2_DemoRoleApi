using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoRoleApi.Controllers
{
    [Authorize("ClientRequired")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            yield return "Client Info 1";
            yield return "Client Info 2";
            yield return "Client Info 3";
            yield return "Client Info 4";
        }
    }
}
