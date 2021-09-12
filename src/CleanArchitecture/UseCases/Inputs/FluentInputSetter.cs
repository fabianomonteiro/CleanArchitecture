using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace UseCases.Inputs
{
    public class FluentInputSetter<TInput>
    {
        public FluentInputSetter<TInput> SetValue<TValue>(Expression<Func<TInput>> memberExpression, TValue value)
        {
            return this;
        }
    }
}
