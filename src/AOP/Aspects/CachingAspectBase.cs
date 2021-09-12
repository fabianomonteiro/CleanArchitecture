using AOP.Aspects;
using System.Threading.Tasks;
using UseCases;

namespace AOP
{
    public abstract class CachingAspectBase : ChangingExecuteAspectBase
    {
        public abstract Task<TOutput> GetCache<TOutput>(IInteractor interactor);

        public override Task<TOutput> Execute<TOutput>(IInteractor interactor) => GetCache<TOutput>(interactor);
    }
}
