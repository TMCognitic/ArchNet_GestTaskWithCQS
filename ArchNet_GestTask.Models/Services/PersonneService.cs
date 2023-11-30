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
    public class PersonneService : IPersonneRepository
    {
        private readonly DbConnection _dbConnection;

        public PersonneService(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Personne> Get()
        {
            _dbConnection.Open();
            return _dbConnection.ExecuteReader("SELECT Id, Nom, Prenom FROM Personne;", record => record.ToPersonne());
        }

        public void Inserer(Personne entity)
        {
            _dbConnection.Open();
            _dbConnection.ExecuteNonQuery("INSERT INTO Personne (Nom, Prenom) VALUES (@Nom, @Prenom);", parameters: new { entity.Nom, entity.Prenom });
        }

        public void Modifier(Personne entity)
        {
            _dbConnection.Open();
            _dbConnection.ExecuteNonQuery("UPDATE Personne SET Nom = @Nom, Prenom = @Prenom WHERE Id = @Id;", parameters: entity);
        }
    }
}
