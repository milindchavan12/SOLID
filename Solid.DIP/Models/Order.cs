using System;
using Solid.DIP.Interfaces;

namespace Solid.DIP.Models
{
    public class Order
    {
        private readonly Cart _cart;
        private readonly PaymentDetails _paymentDetails;
        private readonly INotifyCustomer _notifyCustomer;

        //By Strategy Pattern
        public Order(Cart cart, PaymentDetails paymentDetails, INotifyCustomer notifyCustomer)
        {
            this._cart = cart;
            this._paymentDetails = paymentDetails;
            this._notifyCustomer = notifyCustomer;
        }

        public bool Checkout()
        {
            return true;
        }

    }
}
