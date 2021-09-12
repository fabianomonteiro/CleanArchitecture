using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UseCases.Inputs;

namespace UseCases
{
    public abstract class UseCase<TInput, TOutput> : Interactor<TInput, TOutput>
    {
        public FluentInputSetter<TInput> FluentInput { get; private set; }
    }
}
