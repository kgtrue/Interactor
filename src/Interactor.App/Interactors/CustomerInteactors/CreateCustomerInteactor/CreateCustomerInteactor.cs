using Interactor.App.Common.Handler;
using Interactor.App.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interactor.App.Interactors.CustomerInteactors.CreateCustomerInteactor
{
    public class CreateCustomerInteactor : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        public CreateCustomerInteactor(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
