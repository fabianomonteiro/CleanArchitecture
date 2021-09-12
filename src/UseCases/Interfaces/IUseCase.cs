using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    public interface IUseCase { }

    public interface IUseCase<TInput, TOutput> : IInteractor<TInput, TOutput>, IUseCase
    {
    }
}
