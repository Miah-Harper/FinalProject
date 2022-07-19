using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace FinalProject.Models
{
    public class CheckoutRepository : ICheckOutRepository
    {
        
        private readonly IDbConnection _conn;

        public CheckoutRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void BillingAddress(Checkout checkout)
        {
            throw new NotImplementedException();
        }

        public void Country(Checkout checkout)
        {
            throw new NotImplementedException();
        }

        public void FirstName(Checkout checkout)
        {
            throw new NotImplementedException();
        }

        public void LastName(Checkout checkout)
        {
            throw new NotImplementedException();
        }

        public void OrderID(int id)
        {
            throw new NotImplementedException();
        }

        public void PostalCode(Checkout checkout)
        {
            throw new NotImplementedException();
        }

        public void Price(Checkout checkout)
        {
            throw new NotImplementedException();
        }

        public Checkout ProductID(int id)
        {
            throw new NotImplementedException();
        }

        public void Quantity(Checkout checkout)
        {
            throw new NotImplementedException();
        }

        public void ShippingAddress(Checkout checkout)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Checkout> ShoppingCart()
        {
            throw new NotImplementedException();
        }

        public void State(Checkout checkout)
        {
            throw new NotImplementedException();
        }
    }
}

