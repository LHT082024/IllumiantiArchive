using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IllumiantiArchive.Models
{
    public class Articles
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public int Threatlvl { get; set; }

        public string? Desig { get; set; }

        public int Grade { get; set; }

        public string? Found { get; set; }

        public string? Caused { get; set; }

        public string? Information { get; set; }

        public string? FinalThoughts { get; set; }
    }
}