using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsSampleAPI.Models
{

    [Table(nameof(Customer), Schema = "SalesLT")]
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }

        public bool NameStyle { get; set; }

        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CompanyName { get; set; }
    }
}
