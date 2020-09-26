using Interactor.App.Common.Handler;
using Interactor.App.Contracts;
using Interactor.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            var customer = new Customer() { 
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                Email = request.Email };

            

            _customerRepository.Create(customer);

            throw new NotImplementedException();
        }
    }
}
