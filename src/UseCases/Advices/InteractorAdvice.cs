using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace UseCases.Advices
{
    public class InteractorAdvice : DispatchProxy
    {
        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
