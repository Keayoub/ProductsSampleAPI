using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsSampleAPI.Models
{
    [Table(nameof(Product), Schema = "SalesLT")]
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal ListPrice { get; set; }
        public string ProductNumber { get; set; }

    }
}
