using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UseCases
{
    public abstract class Interactor<TInput, TOutput> : IInteractor<TInput, TOutput>
    {
        private TInput _input;
        private Task<TOutput> _output;

        protected abstract Task<TOutput> ImplementExecute(TInput input);

        public virtual IInteractor<TInput, TOutput> Execute<TCallerInstance>(
            TCallerInstance callerInstance,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0) 
            where TCallerInstance : class, ICallerInstance
        {
            _output = ImplementExecute(_input);

            return this;
        }

        public IInteractor<TInput, TOutput> SetInput(TInput input)
        {
            _input = input;

            return this;
        }

        public Task<TOutput> GetOutputAsync()
        {
            return _output;
        }

        public TOutput GetOutput()
        {
            return _output.Result;
        }
    }
}
