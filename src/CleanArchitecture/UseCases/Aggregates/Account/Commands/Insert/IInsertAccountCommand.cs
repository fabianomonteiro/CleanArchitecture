using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Aggregates.Account.Commands.Insert;

namespace UseCases.Aggregations.Account.Commands
{
    public interface IInsertAccountCommand : ICommand<InsertAccountCommandInput, InsertAccountCommandOutput>
    {
    }
}
