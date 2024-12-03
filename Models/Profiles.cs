using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IllumiantiArchive.Models
{
    //the model class for the profile sets up the basic variables every user will need 
    //to operate on the website. An Id, username, password and 
    //security level to decide how many grades of articles they have acsess too
    public class Profiles
    {
        public int ID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int Securitylvl { get; set; }
    }
}