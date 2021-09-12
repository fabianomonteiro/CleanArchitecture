using System.Threading.Tasks;
using UseCases;

namespace AOP.Aspects
{
    public abstract class ChangingExecuteAspectBase : IAspect
    {
        public abstract bool IsMatch<TInput>(IInteractor interactor, TInput input);

        public abstract Task<TOutput> Execute<TOutput>(IInteractor interactor);
    }
}
