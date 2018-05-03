using System;
using Solid.DIP.Models;

namespace Solid.DIP.Interfaces
{
    public interface INotifyCustomer
    {
        void Notify(Cart cart);
    }
}
