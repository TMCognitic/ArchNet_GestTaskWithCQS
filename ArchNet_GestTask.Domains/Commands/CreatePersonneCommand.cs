using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Commands;

namespace ArchNet_GestTask.Domains.Commands
{
    public class CreatePersonneCommand : ICommandDefinition
    {
        public string Nom { get; init; }
        public string Prenom { get; init; }
        
        public CreatePersonneCommand(string nom, string prenom)
        {
            if (string.IsNullOrWhiteSpace(nom))
                throw new ArgumentException("Le nom doit contenir au moins une lettre.");

            if (string.IsNullOrWhiteSpace(prenom))
                throw new ArgumentException("Le prénom doit contenir au moins une lettre.");

            Nom = nom;
            Prenom = prenom;
        }

    }
}
