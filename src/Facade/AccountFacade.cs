using Facade.Interfaces;
using System.Collections.Generic;
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

        public IQuery<VoidInput, IEnumerable<ListActiveAccountQueryOutput>> ListActive()
        {
            return _listActiveAccountQuery;
        }

        public IQuery<int, GetAccountByIdQueryOutput> GetById()
        {
            return _getAccountByIdQuery;
        }

        public IUseCase<InsertAccountUseCaseInput, InsertAccountUseCaseOutput> Insert()
        {
            return _insertAccountUseCase;
        }

        public IUseCase<UpdateAccountUseCaseInput, UpdateAccountUseCaseOutput> Update()
        {
            return _editAccountUseCase;
        }

        public IUseCase<int, DeleteAccountByIdUseCaseOutput> DeleteById()
        {
            return _deleteAccountByIdUseCase;
        }
    }
}
