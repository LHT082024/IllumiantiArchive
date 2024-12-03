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
            new Profiles{}

        };


    }
}