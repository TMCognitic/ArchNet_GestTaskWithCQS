using MPersonne = ArchNet_GestTask.Models.Entities.Personne;
using ArchNet_GestTask.Business.Entities;

namespace ArchNet_GestTask.Business.Mappers
{
    internal static class Mappers
    {
        internal static MPersonne ToModel(this Personne entity)
        {
            return new MPersonne()
            {
                Id = entity.Id,
                Nom = entity.Nom,
                Prenom = entity.Prenom
            };
        }

        internal static Personne ToBusiness(this MPersonne entity) 
        {
            return new Personne(entity.Id, entity.Nom, entity.Prenom);
        }
    }
}
