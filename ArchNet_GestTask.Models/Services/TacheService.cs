using ArchNet_GestTask.Models.Entities;
using ArchNet_GestTask.Models.Mappers;
using ArchNet_GestTask.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Database;

namespace ArchNet_GestTask.Models.Services
{
    public class TacheService : ITacheRepository
    {
        private readonly DbConnection _dbConnection;

        public TacheService(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Tache> Get()
        {
            _dbConnection.Open();
            return _dbConnection.ExecuteReader("SELECT Id, Titre, [Description], Cloturee, PersonneId FROM Tache;", record => record.ToTache());
        }

        public Tache? Get(int id)
        {
            _dbConnection.Open();
            return _dbConnection.ExecuteReader("SELECT Id, Titre, [Description], Cloturee, PersonneId FROM Tache WHERE Id = @Id;", record => record.ToTache(), parameters: new { id }).SingleOrDefault();
        }

        public void Inserer(Tache entity)
        {
            _dbConnection.Open();
            _dbConnection.ExecuteNonQuery("INSERT INTO Tache (Titre, [Description]) VALUES (@Titre, @Description)", parameters: new { entity.Titre, entity.Description });
        }

        public void Modifier(Tache entity)
        {
            _dbConnection.Open();
            _dbConnection.ExecuteNonQuery("UPDATE Tache SET Titre = @Titre, [Description] = @Description WHERE Id = @Id", parameters: new { entity.Id, entity.Titre, entity.Description });
        }

        public void Assigner(int personneId, int tacheId)
        {
            _dbConnection.Open();
            _dbConnection.ExecuteNonQuery("UPDATE Tache SET PersonneId = @PersonneId WHERE Id = @Id", parameters: new { PersonneId = personneId, Id = tacheId });
        }

        public void Cloturer(int id)
        {
            _dbConnection.Open();
            _dbConnection.ExecuteNonQuery("UPDATE Tache SET Cloturee = 1 WHERE Id = @Id", parameters: new { Id = id });
        }
    }
}
