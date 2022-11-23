using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Cours10.Models
{
    public class Database
    {
        public List<Bee> Bees { get; set; }

        public Database()
        {

            // Créer les listes vides
            Bees = new List<Bee>
            {
                // Créer les abeilles
                new Bee(1, "Maurice", "Maurice est vraiment un lâche. Il s'occupe de ses fleurs à moitié et est souvent en retard."),
                new Bee(2, "Stéphane", "Stéphane est workholic. Il doit apprendre à se détendre."),
                new Bee(3, "Ali", "Ali fait beaucoup d'efforts, mais seulement pour impressionner Isabelle."),
                new Bee(4, "Omar", "Omar prendra bientôt sa retraite, mais il travaille fort."),
                new Bee(5, "Roland", "Roland est une abeille très crédule. Il croit même au Père Pollen."),
                new Bee(6, "Robert", "Robert n'a pas la langue dans sa poche : il insulte souvent ses collègues.")
            };

        }
    }
}
