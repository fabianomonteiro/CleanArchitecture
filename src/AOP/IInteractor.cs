using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UseCases
{
    public interface IInteractor { }

    public interface IInteractor<TInput, TOutput> : IInteractor
    {
        IInteractor<TInput, TOutput> Execute<TCallerInstance>(
            TCallerInstance callerInstance,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
            where TCallerInstance : class, ICallerInstance;

        IInteractor<TInput, TOutput> SetInput(TInput input);

        Task<TOutput> GetOutputAsync();

        TOutput GetOutput();

        IInteractor<TInput, TOutput> MapInput<TSource>(TSource source);

        Task<TDestination> GetOutputAsync<TDestination>();
    }
}
