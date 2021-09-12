using Facade.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases;
using UseCases.Aggregations.Account.Queries;
using UseCases.Aggregations.Account.UseCases.Delete;
using UseCases.Inputs;
using UseCases.Queries;

namespace Facade
{
    public class AccountFacade : ICrudActivableFacadeAsync<
        InsertAccountUseCaseInput,
        InsertAccountUseCaseOutput,
        UpdateAccountUseCaseInput,
        UpdateAccountUseCaseOutput,
        DeleteAccountByIdUseCaseOutput,
        ListActiveAccountQueryOutput,
        GetAccountByIdQueryOutput>
    {
        private readonly IListActiveAccountQuery _listActiveAccountQuery;
        private readonly IGetAccountByIdQuery _getAccountByIdQuery;
        private readonly IInsertAccountUseCase _insertAccountUseCase;
        private readonly IUpdateAccountUseCase _editAccountUseCase;
        private readonly IDeleteAccountByIdUseCase _deleteAccountByIdUseCase;

        public AccountFacade(
            IListActiveAccountQuery listActiveAccountQuery
            , IGetAccountByIdQuery getAccountByIdQuery
            , IInsertAccountUseCase insertAccountUseCase
            , IUpdateAccountUseCase editAccountUseCase
            , IDeleteAccountByIdUseCase deleteAccountByIdUseCase)
        {
            _listActiveAccountQuery = listActiveAccountQuery;
            _getAccountByIdQuery = getAccountByIdQuery;
            _insertAccountUseCase = insertAccountUseCase;
            _editAccountUseCase = editAccountUseCase;
            _deleteAccountByIdUseCase = deleteAccountByIdUseCase;
        }

        public async Task<IEnumerable<ListActiveAccountQueryOutput>> ListActiveAsync()
        {
            return await
                _listActiveAccountQuery
                    .Execute(this)
                    .GetOutputAsync();
        }

        public async Task<GetAccountByIdQueryOutput> GetByIdAsync(int id)
        {
            return await 
                _getAccountByIdQuery
                    .SetInput(id)
                    .Execute(this)
                    .GetOutputAsync();
        }

        public async Task<InsertAccountUseCaseOutput> InsertAsync(InsertAccountUseCaseInput accountInput)
        {
            return await 
                _insertAccountUseCase
                    .SetInput(accountInput)
                    .Execute(this)
                    .GetOutputAsync();
        }

        public InsertAccountUseCaseOutput Insert(InsertAccountUseCaseInput accountInput)
        {
            return 
                _insertAccountUseCase
                    .SetInput(accountInput)
                    .Execute(this)
                    .GetOutput();
        }

        public async Task<UpdateAccountUseCaseOutput> UpdateAsync(UpdateAccountUseCaseInput accountInput)
        {
            return await 
                _editAccountUseCase
                    .SetInput(accountInput)
                    .Execute(this)
                    .GetOutputAsync();
        }

        public async Task<DeleteAccountByIdUseCaseOutput> DeleteByIdAsync(int id)
        {
            return await
                _deleteAccountByIdUseCase
                    .SetInput(id)
                    .Execute(this)
                    .GetOutputAsync();
        }
    }
}
