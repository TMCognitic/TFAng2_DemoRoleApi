using DemoRoleApi.Infrastructure;
using DemoRoleApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoRoleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenManager _tokenManager;
        public AuthController(TokenManager tokenManager)
        {
            _tokenManager = tokenManager;
        }

        [HttpPost("ClientLogin")]
        public Client ClientLogin()
        {
            Client client = new Client()
            {
                Id = 1,
                LastName = "Doe",
                FirstName = "John",
                Email = "john.doe@unknow.com"
            };

            client.Token = _tokenManager.GenerateJWT(client);

            return client;
        }

        [HttpPost("DevelopperLogin")]
        public Developper DevelopperLogin()
        {
            Developper developper = new Developper()
            {
                Id = 1,
                LastName = "Doe",
                FirstName = "Jane",
                Email = "jane.doe@unknow.com"
            };

            developper.Token = _tokenManager.GenerateJWT(developper);

            return developper;
        }
    }
}
