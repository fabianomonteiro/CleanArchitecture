using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UseCases.Inputs;

namespace UseCases.Aggregations.Account.UseCases.Delete
{
    public class DeleteAccountByIdUseCase : UseCase<int, DeleteAccountByIdUseCaseOutput>, IDeleteAccountByIdUseCase
    {
        protected override Task<DeleteAccountByIdUseCaseOutput> ImplementExecute(int input)
        {
            throw new NotImplementedException();
        }
    }
}
