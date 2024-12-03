using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IllumiantiArchive.Models;
using Microsoft.AspNetCore.Mvc;

namespace IllumiantiArchive.Controllers
{
    [ApiController]
    [Route("profiles")]
    public class loginController
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


    }
}