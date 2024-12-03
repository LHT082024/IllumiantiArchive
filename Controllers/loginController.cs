using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IllumiantiArchive.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace IllumiantiArchive.Controllers
{
    [ApiController]
    [Route("profiles")]
    public class loginController : ControllerBase
    {
        List<Profiles> profiles = new List<Profiles>()
        {
            new Profiles{ID = 1,
            Username = "Snorre",
            Password = "ReykholtIsBae1179",
            Securitylvl = 1
            },

            new Profiles{ID = 2,
            Username = "Brian",
            Password = "CatGirlLover2001",
            Securitylvl = 2
            }
        };

        [HttpPost("login")]
        public IActionResult Login([FromBody] Profiles loginRequest)
        {
            var user = profiles.FirstOrDefault(u =>
            u.Username == loginRequest.Username &&
            u.Password == loginRequest.Password);

            if (user == null)
            {
                return Unauthorized(new { Message = "Invalid Username or Password" });
            }

            return Ok(new { Message = "Login sucessful", profiles = user });


        }
    }


}