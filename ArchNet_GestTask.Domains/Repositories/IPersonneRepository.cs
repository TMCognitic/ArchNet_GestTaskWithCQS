using ArchNet_GestTask.Domains.Commands;
using ArchNet_GestTask.Domains.Entities;
using ArchNet_GestTask.Domains.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Commands;
using Tools.CQS.Queries;

namespace ArchNet_GestTask.Domains.Repositories
{
    public interface IPersonneRepository :
        ICommandHandler<CreatePersonneCommand>,
        ICommandHandler<UpdatePersonneCommand>,
        IQueryHandler<GetAllPersonneQuery, IEnumerable<Personne>>
    {
        
    }
}
