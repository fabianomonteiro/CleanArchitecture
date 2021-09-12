using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.Aggregations.Account.UseCases.Delete
{
    public interface IDeleteAccountByIdUseCase : IUseCase<int, DeleteAccountByIdUseCaseOutput>
    {
    }
}
