using UseCases.Outputs;

namespace UseCases.Queries
{
    public interface IGetAccountByIdQuery : IQuery<int, GetAccountByIdQueryOutput>
    {
    }
}
