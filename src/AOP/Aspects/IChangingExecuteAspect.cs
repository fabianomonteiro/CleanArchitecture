using System.Threading.Tasks;
using UseCases;

namespace AOP.Aspects
{
    public interface IChangingExecuteAspect : IAspect
    {
        Task<TOutput> Execute<TOutput>(IInteractor interactor);
    }
}
