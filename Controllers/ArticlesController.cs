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
        private static List<Articles> articlesGrade2 = new List<Articles>()
        {
            new Articles
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

             new Articles
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


    }
}