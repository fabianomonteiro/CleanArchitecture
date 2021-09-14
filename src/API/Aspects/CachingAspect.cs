using AOP;
using System;
using System.Threading.Tasks;
using UseCases;

namespace API.Aspects
{
    public class CachingAspect : CachingAspectBase
    {
        public override bool IsMatch<TInput>(IInteractor interactor, TInput input)
        {
            return true;
        }

        public override Task<TOutput> GetCache<TOutput>(IInteractor interactor)
        {
            // Lógica de Cache

            return Task.FromResult(Activator.CreateInstance<TOutput>());
        }
    }
}
