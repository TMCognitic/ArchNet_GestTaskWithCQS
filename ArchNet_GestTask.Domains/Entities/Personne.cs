using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchNet_GestTask.Domains.Entities
{
        public class Personne
        {
            public int Id { get; init; }
            public string Nom { get; set; }
            public string Prenom { get; set; }

            public Personne(string nom, string prenom)
            {
                Nom = nom;
                Prenom = prenom;
            }

            internal Personne(int id, string nom, string prenom)
                : this(nom, prenom)
            {
                Id = id;
            }
        }
}
