using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Commands;

namespace ArchNet_GestTask.Domains.Commands
{
    public class UpdatePersonneCommand : ICommandDefinition
    {
        public int Id { get; init; }
        public string Nom { get; init; }
        public string Prenom { get; init; }
        public UpdatePersonneCommand(int id, string nom, string prenom)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }
    }
}
