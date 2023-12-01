using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.CQS.Commands;

namespace Tools.CQS.Queries
{
    public class QueryResult<TResult>
        where TResult : class
    {
        public static QueryResult<TResult> Success(TResult result)
        {
            return new QueryResult<TResult>(true, result:result);
        }

        public static QueryResult<TResult> Failure(string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(errorMessage))
                throw new ArgumentException("En cas d'échec le message d'erreur est obligatoire.");

            return new QueryResult<TResult>(false, errorMessage, null);
        }

        public bool IsSuccess { get; init; }
        public bool IsFailure { get { return !IsSuccess; } }
        public string? ErrorMessage { get; init; }
        public TResult? Result { get; init; }

        private QueryResult(bool isSuccess, string? errorMessage = null, TResult? result = null)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            Result = result;
        }
    }
}
