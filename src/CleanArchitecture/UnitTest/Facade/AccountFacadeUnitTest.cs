using Facade;
using Moq;
using System.Threading.Tasks;
using UseCases;
using UseCases.Aggregations.Account.Commands;
using UseCases.Aggregations.Account.UseCases.Delete;
using UseCases.Inputs;
using UseCases.Queries;
using Xunit;

namespace UnitTest.Facade
{
    public class AccountFacadeUnitTest
    {
        [Fact]
        public void Test_Insert_Account_Sync()
        {
            var listActiveAccountQueryMock = new Mock<IListActiveAccountQuery>();
            var getAccountByIdQueryMock = new Mock<IGetAccountByIdQuery>();
            var insertAccountCommandMock = new Mock<IInsertAccountCommand>();
            var insertAccountUseCase = new InsertAccountUseCase(insertAccountCommandMock.Object);
            var editAccountUseCase = new UpdateAccountUseCase();
            var deleteAccountByIdUseCase = new DeleteAccountByIdUseCase();
            var accountFacade = new AccountFacade
                (
                    listActiveAccountQueryMock.Object
                    , getAccountByIdQueryMock.Object
                    , insertAccountUseCase
                    , editAccountUseCase
                    , deleteAccountByIdUseCase
                );

            var input = new InsertAccountUseCaseInput();
            var output = accountFacade.Insert(input);
        }

        [Fact]
        public async Task Test_Insert_Account_Async()
        {
            var listActiveAccountQueryMock = new Mock<IListActiveAccountQuery>();
            var getAccountByIdQueryMock = new Mock<IGetAccountByIdQuery>();
            var insertAccountCommandMock = new Mock<IInsertAccountCommand>();
            var insertAccountUseCase = new InsertAccountUseCase(insertAccountCommandMock.Object);
            var editAccountUseCase = new UpdateAccountUseCase();
            var deleteAccountByIdUseCase = new DeleteAccountByIdUseCase();
            var accountFacade = new AccountFacade
                (
                    listActiveAccountQueryMock.Object
                    , getAccountByIdQueryMock.Object
                    , insertAccountUseCase
                    , editAccountUseCase
                    , deleteAccountByIdUseCase
                );

            var input = new InsertAccountUseCaseInput();
            var output = await accountFacade.InsertAsync(input);
        }
    }
}
