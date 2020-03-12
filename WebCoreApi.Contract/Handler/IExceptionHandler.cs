using System;
using System.Collections.Generic;
using System.Text;

namespace WebCoreApi.Contract.Handler
{
    public interface IExceptionHandler
    {
        T Run<T>(Func<T> func);
    }
}
