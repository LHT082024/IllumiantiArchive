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

    //the loginController handles everything about the user profiles. 
    //first we have a list of every profile. Passwords arent Hashed
    //and everything is stored directly into the code instead of a database
    //beacuse my main priority here was just having a fun and easy website
    //where I created a login system with different privliages depending on 
    // the "security level" of the user, not really security.
    [Route("api/[controller]")]
    [ApiController]
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


        //the first http method. it's used for login as it is named.
        //it uses httpContext.session to store the current username and securtylvl
        //in the session so it can be used in the Article classes to check
        //if the current user have acsess to the current Article
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

            // return Ok(new { Message = "Login sucessful", profiles = user });
            return Ok(new { Message = "Login successful", user = new { Username = user.Username, SecurityLevel = user.Securitylvl } });
        }

        //a method that lets you check if there are anyone currently logged in
        //and if they are, it prints the username.
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


        //by clearing the session data you are effectivly logged out
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // Clear all session data
            HttpContext.Session.Clear();

            return Ok(new { Message = "You have logged out successfully" });
        }
    }
}