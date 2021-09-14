using UseCases;

namespace AOP
{
    public interface IAspect
    {
        public abstract bool IsMatch<TInput>(IInteractor interactor, TInput input);
    }
}
