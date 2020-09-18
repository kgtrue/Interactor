using Interactor.App.Common.Handler;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interactor.App.Interactors.CustomerInteactors.CreateCustomerInteactor
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
}
