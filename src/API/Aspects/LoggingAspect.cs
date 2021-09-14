using AOP;
using System;
using UseCases;

namespace API.Aspects
{
    public class LoggingAspect : ILoggingAspect
    {
        public bool IsMatch<TInput>(IInteractor interactor, TInput input)
        {
            return true;
        }

        public void LogStartExecute(IInteractor interactor)
        {
            // Lógica de log
        }

        public void LogEndExecute(IInteractor interactor, TimeSpan timeSpanExecution, bool executeFromAspect, IAspect aspectExecutedInstance)
        {
            // Lógica de log
        }

        public void LogExceptionExecute(IInteractor interactor, Exception exception)
        {
            // Lógica de log
        }
    }
}
