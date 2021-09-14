using AOP;
using System;
using System.Threading.Tasks;
using UseCases;

namespace API.Aspects
{
    public class MappingAspect : IMappingAspect
    {
        public bool IsMatch<TInput>(IInteractor interactor, TInput input)
        {
            return true;
        }

        public Task<TDestination> Map<TSource, TDestination>(TSource source)
        {
            // Lógica de mapeamento

            return Task.FromResult(Activator.CreateInstance<TDestination>());
        }
    }
}
