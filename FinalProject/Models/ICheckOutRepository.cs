using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public interface ICheckOutRepository
    {
      
        public IEnumerable<Checkout> ShoppingCart();
        public Checkout ProductID(int id);
        public void OrderID(int id);
        public void Quantity(Checkout checkout);
        public void Price(Checkout checkout);
        public void FirstName(Checkout checkout);
        public void LastName(Checkout checkout);
        public void ShippingAddress(Checkout checkout);
        public void BillingAddress(Checkout checkout);
        public void State(Checkout checkout);
        public void PostalCode(Checkout checkout);
        public void Country(Checkout checkout);

    }

}

