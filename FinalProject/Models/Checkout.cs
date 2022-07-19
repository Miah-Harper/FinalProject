using System;
namespace FinalProject.Models
{
    public class Checkout
    {
            public int OrderID { get; set; }
            public string FirstName {get; set;}
            public string LastName { get; set; }
            public string EmailAddress { get; set; }
            public string ShippingAddress { get; set; }
            public string BillingAddress { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
            public int PostalCode { get; set; }
            public int Price { get; set; }
            public int Qauntity { get; set; }
        
    }
}

