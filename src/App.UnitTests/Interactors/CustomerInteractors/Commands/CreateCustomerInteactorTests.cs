using Interactor.App.Common.Handler;
using Interactor.App.Contracts;
using Interactor.App.Interactors.CustomerInteactors.CreateCustomerInteactor;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace App.UnitTests.Interactors.CustomerInteractors.Commands
{
    public class CreateCustomerInteactorTests
    {
        [Fact]
        public void CreateCustomerTest()
        {
            var request = new Mock<CreateCustomerRequest>();
            var customerRepo = new Mock<ICustomerRepository>();
            var inteactor = new CreateCustomerInteactor(customerRepo.Object);
            var response = inteactor.Handle(request.Object);
            Assert.True(response.Result == true);
        }
    }
}
