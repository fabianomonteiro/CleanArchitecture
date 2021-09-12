using AOP;
using API.Aspects;
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
    public class AccountFacadeUnitTest : ICallerInstance
    {
        [Fact]
        public void Test_Insert_Account_Sync()
        {
            AspectWeaver.Instance.AddAspect<LoggingAspect>();
            AspectWeaver.Instance.AddAspect<CachingAspect>();
            AspectWeaver.Instance.AddAspect<MappingAspect>();

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
            var output = 
                accountFacade
                    .Insert()
                    .MapInput(input)
                    .Execute(this)
                    .GetOutputAsync<InsertAccountUseCaseInput>();
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
            var output = await 
                accountFacade
                    .Insert()
                    .SetInput(input)
                    .Execute(this)
                    .GetOutputAsync();
        }
    }
}
