using Entities.Account;
using UseCases.Inputs;
using UseCases.Outputs;

namespace UseCases
{
    public interface IInsertAccountUseCase : IUseCase<InsertAccountUseCaseInput, InsertAccountUseCaseOutput>
    {
    }
}
