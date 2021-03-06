using Shopel.Services.DataAccess;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopel.DataAccess
{
    [Table("CartItems")]
    public class ProductDb
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public double Shipping { get; set; }
        public string Upc { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
    }
}
