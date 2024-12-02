using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IllumiantiArchive.Models;
using Microsoft.AspNetCore.Mvc;

namespace IllumiantiArchive.Controllers
{
    [ApiController]
    [Route("Controllers")]
    public class ArticlesController
    {
        //the most dangoures anomalies
        private static List<Articles> articlesGrade1 = new List<Articles>()
        {
            new Articles{ID = 1, }

        };


    }
}