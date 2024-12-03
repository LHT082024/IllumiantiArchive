using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IllumiantiArchive.Models;
using Microsoft.AspNetCore.Mvc;

namespace IllumiantiArchive.Controllers
{
    [ApiController]
    [Route("Grade2")]

    //5/10 dangoures Anomolies, most employees will know about these.
    public class ArticleGrade2Controller
    {

        private static List<Articles2> articlesGrade2 = new List<Articles2>()
        {

              new Articles2
             {ID = 4,
             Name = "Mi-go",
             Aliases = "The Fungi",
             Threatlvl = 4,
             Desig = "Bug",
             Found = "Usually on moons of planets with human inhabitants",
             Caused = "traveling",
             Apperal = "Generaly looks like a crustacean animal but bodies made up of eldritch matter",
             Information = "they travel to planets to extract metals and knowledge to what end we are not sure",
             FinalThoughts = "any sighting are to be reported directly to your superior. avoid any and all hostile actions unless it is in self defense, dont accept any offers of knowledge"
             },

             new Articles2
             {ID = 5,
             Name = "Zann",
             Aliases = "the Musican",
             Threatlvl = 3,
             Desig = "Eldritch corrupted human",
             Found = "Usually found with one of the eldritch gods, permant resident possibly n1905",
             Caused = "Unatrual sound",
             Apperal = "A hooded figure with a violin",
             Information = "The Musican is known for playing beautiful but uncanny music, has been seen several times playing for different deities",
             FinalThoughts = "Every encounter with the man has been plesant, valuble resource in gathering information about the gods. Chatting recomended but dont let him play for you"
             }
        };

        // //grade 2 articles
        [HttpGet]
        public IEnumerable<Articles2> GetGrade2()
        {
            return articlesGrade2;
        }

    }
}