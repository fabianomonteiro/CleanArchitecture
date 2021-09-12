using System.Collections.Generic;
using UseCases.Aggregations.Account.Queries;
using UseCases.Inputs;

namespace UseCases.Queries
{
    public interface IListActiveAccountQuery : IInteractor<VoidInput, IEnumerable<ListActiveAccountQueryOutput>>
    {
    }
}
