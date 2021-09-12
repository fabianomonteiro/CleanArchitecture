using System.Runtime.CompilerServices;

namespace UseCases
{
    public interface ICommand<TInput, TOutput> : IInteractor<TInput, TOutput>
    {
        new ICommand<TInput, TOutput> Execute<TCallerInstance>(
            TCallerInstance callerInstance,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
            where TCallerInstance : class, IUseCase;

        new ICommand<TInput, TOutput> SetInput(TInput input);
    }
}
