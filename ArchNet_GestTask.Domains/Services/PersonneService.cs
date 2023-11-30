using ArchNet_GestTask.Domains.Commands;
using ArchNet_GestTask.Domains.Entities;
using ArchNet_GestTask.Domains.Mappers;
using ArchNet_GestTask.Domains.Queries;
using ArchNet_GestTask.Domains.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Commands;
using Tools.CQS.Queries;
using Tools.Database;

namespace ArchNet_GestTask.Domains.Services
{
    public class PersonneService : IPersonneRepository
    {
        private readonly DbConnection _dbConnection;

        public PersonneService(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public CommandResult Execute(CreatePersonneCommand command)
        {
            try
            {
                _dbConnection.Open();
                _dbConnection.ExecuteNonQuery("INSERT INTO Personne (Nom, Prenom) VALUES (@Nom, @Prenom);", parameters: command);
                return CommandResult.Success();
            }
            catch (Exception ex)
            {
                return CommandResult.Failure(ex.Message);
            }
        }

        public CommandResult Execute(UpdatePersonneCommand command)
        {
            try
            {
                _dbConnection.Open();
                int rows = _dbConnection.ExecuteNonQuery("UPDATE Personne SET Nom = @Nom, Prenom = @Prenom WHERE Id = @Id;", parameters: command);

                if (rows != 1)
                    return CommandResult.Failure($"Nombre ligne modifiée incorrecte : {rows} ligne(s)");

                return CommandResult.Success();
            }
            catch (Exception ex)
            {
                return CommandResult.Failure(ex.Message);
            }
        }

        public QueryResult<IEnumerable<Personne>> Execute(GetAllPersonneQuery query)
        {
            try
            {
                _dbConnection.Open();
                return QueryResult<IEnumerable<Personne>>.Success(_dbConnection.ExecuteReader("SELECT Id, Nom, Prenom FROM Personne;", record => record.ToPersonne()));
            }
            catch (Exception ex)
            {
                return QueryResult<IEnumerable<Personne>>.Failure(ex.Message);
            }
        }
    }
}
