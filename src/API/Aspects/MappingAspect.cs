using AOP;
using System;
using System.Threading.Tasks;

namespace API.Aspects
{
    public class MappingAspect : MappingAspectBase
    {
        public override Task<TDestination> Map<TSource, TDestination>(TSource source)
        {
            return Task.FromResult(Activator.CreateInstance<TDestination>());
        }
    }
}
