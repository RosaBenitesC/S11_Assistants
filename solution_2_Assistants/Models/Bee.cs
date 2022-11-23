using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Cours10.Models
{
    public class Bee
    {
        
        public int Id { get; set; }

        
        public string Nom { get; set; }

        
        public bool EnVacances { get; set; }

       
        public string Description { get; set; }
        public Bee (int id, string name, string description)
        {
            Id = id;
            Nom = name;
            EnVacances = false;
            Description = description;
        }
        public Bee() { }

    }
}
