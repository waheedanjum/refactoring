using System;
using Xunit;
using Moq;
using AutoFixture;
using Smartwyre.DeveloperTest.Types;
using Smartwyre.DeveloperTest.Services;


namespace Smartwyre.DeveloperTest.Tests
{
    public class PaymentServiceTests
    {
        private readonly Fixture fixture;
        private readonly PaymentService _ps;
        private Mock<IAccountDataStore> _accountDataStore = new Mock<IAccountDataStore>();
       
        public PaymentServiceTests()
        {
             fixture = new Fixture();
            _ps = new PaymentService(_accountDataStore.Object);
        }

        [Fact]
        public async void MakePaymentAsync_ShouldReturnFalse()
        {
            // Arrange
            var paymentRequest = new MakePaymentRequest();
            var paymentResult = new MakePaymentResult();

            var account = new Account();
            
            _accountDataStore.Setup(x => x.GetAccountAsync(fixture.Freeze<string>())).ReturnsAsync(account);

            // Act
            var result = await _ps.MakePaymentAsync(paymentRequest);

            // Assert 
            Assert.Equal(paymentResult.Success, result.Success);

        }
    }
}
