using Entities.Account;
using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Aggregates.Account.Commands.Insert;

namespace UseCases.Inputs
{
    public class InsertAccountUseCaseInput
    {
        internal InsertAccountCommandInput ToInsertAccountCommandInput()
        {
            return new InsertAccountCommandInput();
        }
    }
}
