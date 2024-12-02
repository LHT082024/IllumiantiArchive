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
        private static List<Articles> articlesGrade10 = new List<Articles>()
        {
            new Articles{ID = 1,
            Name = "Odin",
            Threatlvl = 10,
            Desig ="Deity",
            Found = " M1804(Home?), M2008, N3001",
            Caused ="mass Ressurection",
            Information = "Odin often takes the shape of a girl wearing a mask with the runic o on it. black feather wings is also a common sight",
            FinalThoughts = "While dangoures messing with deities has never been good for the organization. Avoid at all cost. If you have to engage do with a friendly tone",
            },

            new Articles{ID = 1,
            Name =
            }


        };


    }
}