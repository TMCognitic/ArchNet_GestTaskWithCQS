using ArchNet_GestTask.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchNet_GestTask.Models.Repositories
{
    public interface ITacheRepository
    {
        IEnumerable<Tache> Get();
        Tache? Get(int id);
        void Inserer(Tache entity);
        void Modifier(Tache entity);
        void Assigner(int personneId, int tacheId); //Assigner une tache ? Personne ou Tache
        void Cloturer(int id);
    }
}
