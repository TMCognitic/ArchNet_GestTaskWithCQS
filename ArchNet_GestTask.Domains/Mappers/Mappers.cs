using ArchNet_GestTask.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchNet_GestTask.Domains.Mappers
{
    internal static class Mappers
    {
        internal static Personne ToPersonne(this IDataRecord record)
        {            
            return new Personne((int)record["Id"], (string)record["Nom"], (string)record["Prenom"]);
        }

        //internal static Tache ToTache(this IDataRecord record)
        //{
        //    return new Tache()
        //    {
        //        Id = (int)record["Id"],
        //        Titre = (string)record["Titre"],
        //        Description = (string)record["Description"],
        //        Cloturee = (bool)record["Cloturee"],
        //        PersonneId = record["PersonneId"] as int?
        //    };
        //}
    }
}
