using AOP.Aspects;
using System.Threading.Tasks;
using UseCases;

namespace AOP
{
    public abstract class CachingAspectBase : IChangingExecuteAspect
    {
        public abstract bool IsMatch<TInput>(IInteractor interactor, TInput input);

        public abstract Task<TOutput> GetCache<TOutput>(IInteractor interactor);

        public Task<TOutput> Execute<TOutput>(IInteractor interactor) => GetCache<TOutput>(interactor);
    }
}
