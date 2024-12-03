using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IllumiantiArchive.Models;
using Microsoft.AspNetCore.Mvc;

namespace IllumiantiArchive.Controllers
{

    [ApiController]
    [Route("Grade 1")]
    public class ArticleGrade1Controller : ControllerBase
    {
        Profiles profiles = new Profiles();
        //the most dangoures anomalies only leaders will have acsess to these files
        private static List<Articles> articlesGrade1 = new List<Articles>()
        {
            new Articles{ID = 1,
            Name = "Odin",
            Aliases = "Lillith, God of magic, The heir, The Angel Swiftport",
            Threatlvl = 10,
            Desig ="Deity",
            Found = " M1804(Home?), M2008, N3001",
            Caused ="Traveling, Mass Ressurection",
            Apperal = "Young woman with face covering mask the o rune painted on, angelic girl with white featherd wings, angelic girl with black featherd wings",
            Information = "relaxed personality, sociabale.",
            FinalThoughts = "While a clear danger to our cause messing with deities has never been good for the organization. Avoid at all cost. If you have to engage do with a friendly tone",
            },

            new Articles{ID = 2,
            Name = "Salem",
            Aliases = "Stupid-ears(need to reaserch origin), The god of demons, Angel slayer, Hells revenge",
            Threatlvl = 10,
            Desig = "Deity",
            Found = "Hell(assumed home), M2008, M1301, N2002",
            Caused = "Traveling, Time-loops, Terraforming",
            Apperal = "Tall man with dark hair, horse, winged demon, Bug",
            Information = "has a temper, hates angels, hates being called stupid-ears",
            FinalThoughts = "While new recruits might find him relaxed and pleasent older recruits will never forget the portal incident"
            },

            new Articles{ID = 3,
            Name = "Emma",
            Aliases = "Annoying-bitch(still waiting for a source Brian..), God of chaos, Chesire cat,",
            Threatlvl = 10,
            Desig = "Deity(possible avatar of A)",
            Found = "M2008, M1301, N2002, Hell, N1704, N3001, N905, M1804 ",
            Caused = "Traveling, Time-loops, terraforming, reality creation, (possible) eating, Time freeze",
            Apperal = "Short young woman, a shapeless cluster of tentacles",
            Information = "Has extreme moodswings, Usually very sweet, relaxed likes to tell jokes then at the drop of a hat turns unpleasent and agressive",
            FinalThoughts = "dont engage, if you see her leave the reality immideatly and report it to S"
            },
        };

        //5/10 dangoures Anomolies, most employees will know about these.

        //Grade 1 articles.
        [HttpGet]
        public IActionResult GetGrade1()
        {
            var securityLevel = HttpContext.Session.GetInt32("SecurityLevel");

            if (securityLevel == 1)
            {
                return Ok(articlesGrade1);
            }

            return Unauthorized(new { Message = "You are either not logged in or your secuirty level is too low" });


        }

    }
}