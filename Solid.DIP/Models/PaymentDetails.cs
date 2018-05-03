using System;
namespace Solid.DIP.Models
{
    public class PaymentDetails
    {
        public PaymentMethod PaymentMethod;
    }

    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        DebitCard
    }
}

