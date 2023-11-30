using ArchNet_GestTask.Domains.Commands;
using ArchNet_GestTask.Domains.Entities;
using ArchNet_GestTask.Domains.Queries;
using ArchNet_GestTask.Domains.Repositories;
using ArchNet_GestTask.Domains.Services;
using System.Data.Common;
using System.Data.SqlClient;
using Tools.CQS.Commands;
using Tools.CQS.Queries;

namespace ArchNet_GestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(DbConnection connection = new SqlConnection(@"Data Source=Briareos-AW2\SQL2022DEV;Initial Catalog=GestTask;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=true;"))
            {
                IPersonneRepository repository = new PersonneService(connection);

                QueryResult<IEnumerable<Personne>> queryResult = repository.Execute(new GetAllPersonneQuery());

                if(queryResult.IsSuccess)
                {
                    foreach (Personne p in queryResult.Result!)
                    {
                        Console.WriteLine(p.Nom);
                    }
                }


                //CommandResult result = repository.Execute(new CreatePersonneCommand("Woodpecker", "Woody"));
                //if(result.IsSuccess)
                //{
                //    Console.WriteLine("Insertion réussie");
                //}
                //else
                //{
                //    Console.WriteLine($"Un problème est survernu : \n{result.ErrorMessage}");
                //}
            }         
            

        }
    }
}
