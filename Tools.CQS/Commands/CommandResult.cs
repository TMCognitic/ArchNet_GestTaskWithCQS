using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.CQS.Commands
{
    public class CommandResult
    {
        public static CommandResult Success()
        {
            return new CommandResult(true);
        }

        public static CommandResult Failure(string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(errorMessage))
                throw new ArgumentException("En cas d'échec le message d'erreur est obligatoire.");

            return new CommandResult(false, errorMessage);
        }

        public bool IsSuccess { get; init; }
        public bool IsFailure { get { return !IsSuccess; } }
        public string? ErrorMessage { get; init; }

        private CommandResult(bool isSuccess, string? errorMessage = null)
        {            
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
        }
    }
}
