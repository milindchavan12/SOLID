using System;
using Xunit;
using Solid.DIP.Models;
using Solid.DIP;

namespace Solid.Tests
{
    public class OrderDependencyInjectionTests
    {
        [Fact]
        public void NotFailWithNoItemsNoNotificationNoCreditcard()
        {
            var cart = new Cart();
            var paymentDetails = new PaymentDetails { PaymentMethod = PaymentMethod.Cash };
            var notifyCustomerService = new NotifyCustomerService();

            var order = new Order(cart, paymentDetails, notifyCustomerService);

            Assert.True(order.Checkout());
        }
    }
}
