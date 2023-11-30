using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.CQS.Queries
{
    public interface IQueryHandler<TQuery, TResult>
        where TQuery : IQueryDefinition<TResult>
        where TResult : class
    {
        QueryResult<TResult> Execute(TQuery query);
    }
}
