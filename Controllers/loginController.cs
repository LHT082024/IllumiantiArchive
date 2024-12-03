using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IllumiantiArchive.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

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

            //stores username and securitylvl in the session.
            HttpContext.Session.SetString("LoggedInUser", user.Username);
            HttpContext.Session.SetInt32("SecurityLevel", user.Securitylvl);

            return Ok(new { Message = "Login sucessful", profiles = user });
        }

        [HttpGet("current")]
        public IActionResult CurrentUser()
        {
            var username = HttpContext.Session.GetString("LoggedInUser");

            if (string.IsNullOrEmpty(username))
            {
                return Unauthorized(new { Message = "No user is logged in" });
            }

            return Ok(new { Message = "Current User", Username = username });
        }
    }
}