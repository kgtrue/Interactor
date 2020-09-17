using System;
using System.Collections.Generic;
using System.Text;

namespace Interactor.App.Common.Handler
{
    public interface IRequestHandler<in TRequest, out TResponse>  where TRequest: IRequest<TResponse>  
    {
        TResponse Handle(TRequest request);
    }
}
