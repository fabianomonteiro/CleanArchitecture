using System;
using UseCases;

namespace AOP
{
    public interface ILoggingAspect : IAspect
    {
        public abstract void LogStartExecute(IInteractor interactor);

        public abstract void LogEndExecute(IInteractor interactor, TimeSpan timeSpanExecution, bool executeFromAspect, IAspect aspectExecutedInstance);

        public abstract void LogExceptionExecute(IInteractor interactor, Exception exception);
    }
}
