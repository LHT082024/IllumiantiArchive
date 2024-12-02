using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IllumiantiArchive.Models
{
    public class Profiles
    {
        public int ID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public int Securitylvl { get; set; }
    }
}