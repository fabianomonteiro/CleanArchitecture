using AOP;
using AOP.Aspects;
using System;
using System.Diagnostics;
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
            try
            {
                AspectWeaver.Instance.LoggingAspect?.LogStartExecute(this);

                var stopwatch = new Stopwatch();

                stopwatch.Start();

                ChangingExecuteAspectBase changingExecuteAspect;

                _output = InternalImplementExecute(out changingExecuteAspect);

                stopwatch.Stop();

                AspectWeaver.Instance.LoggingAspect?.LogEndExecute(this, stopwatch.Elapsed, changingExecuteAspect != null, changingExecuteAspect);
            }
            catch (Exception ex)
            {
                AspectWeaver.Instance.LoggingAspect?.LogExceptionExecute(this, ex);

                throw ex;
            }

            return this;
        }

        private Task<TOutput> InternalImplementExecute(out ChangingExecuteAspectBase changeExecuteAspect)
        {
            if (AspectWeaver.Instance.IsChangingExecuteAspect)
            {
                changeExecuteAspect = AspectWeaver.Instance.GetChangingExecuteAspect(this, _input);

                return changeExecuteAspect.Execute<TOutput>(this);
            }

            changeExecuteAspect = null;

            return ImplementExecute(_input);
        }

        public IInteractor<TInput, TOutput> SetInput(TInput input)
        {
            _input = input;

            return this;
        }

        public async Task<TOutput> GetOutputAsync()
        {
            return await _output;
        }

        public TOutput GetOutput()
        {
            return _output.Result;
        }

        public IInteractor<TInput, TOutput> MapInput<TSource>(TSource source)
        {
            _input = AspectWeaver.Instance.MappingAspect.Map<TSource, TInput>(source).Result;

            return this;
        }

        public async Task<TDestination> GetOutputAsync<TDestination>()
        {
            return await AspectWeaver.Instance.MappingAspect.Map<TOutput, TDestination>(_output.Result);
        }
    }
}
