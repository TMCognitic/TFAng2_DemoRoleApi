using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoRoleApi.Models
{
    public class Developper : IUser
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
