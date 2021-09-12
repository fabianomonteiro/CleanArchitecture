using System;
using System.Threading.Tasks;
using UseCases.Inputs;
using UseCases.Outputs;

namespace UseCases
{
    public class UpdateAccountUseCase : UseCase<UpdateAccountUseCaseInput, UpdateAccountUseCaseOutput>, IUpdateAccountUseCase
    {
        protected override Task<UpdateAccountUseCaseOutput> ImplementExecute(UpdateAccountUseCaseInput input)
        {
            throw new NotImplementedException();
        }
    }
}
