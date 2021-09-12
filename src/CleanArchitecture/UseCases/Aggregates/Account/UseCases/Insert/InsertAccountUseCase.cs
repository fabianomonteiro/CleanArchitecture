using System.Threading.Tasks;
using UseCases.Aggregations.Account.Commands;
using UseCases.Inputs;

namespace UseCases
{
    public class InsertAccountUseCase : UseCase<InsertAccountUseCaseInput, InsertAccountUseCaseOutput>, IInsertAccountUseCase
    {
        private readonly IInsertAccountCommand _insertAccountCommand;

        public InsertAccountUseCase(IInsertAccountCommand insertAccountCommand)
        {
            _insertAccountCommand = insertAccountCommand;
        }

        protected async override Task<InsertAccountUseCaseOutput> ImplementExecute(InsertAccountUseCaseInput input)
        {
            var commandOutput = await
                _insertAccountCommand
                    .SetInput(input.ToInsertAccountCommandInput())
                    .Execute(this)
                    .GetOutputAsync();

            return await Task.FromResult(new InsertAccountUseCaseOutput());
        }
    }
}
