using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AOP
{
    public interface IMappingAspect : IAspect
    {
        public abstract Task<TDestination> Map<TSource, TDestination>(TSource source);
    }
}
