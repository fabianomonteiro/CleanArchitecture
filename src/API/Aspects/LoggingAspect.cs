using AOP;
using System;
using UseCases;

namespace API.Aspects
{
    public class LoggingAspect : LoggingAspectBase
    {
        public override void LogStartExecute(IInteractor interactor)
        {

        }

        public override void LogEndExecute(IInteractor interactor, TimeSpan timeSpanExecution, bool executeFromAspect, IAspect aspectExecutedInstance)
        {
            
        }

        public override void LogExceptionExecute(IInteractor interactor, Exception exception)
        {
            
        }
    }
}
