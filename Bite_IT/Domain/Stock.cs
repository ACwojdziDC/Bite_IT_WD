using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bite_IT.Domain
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<ProductInStock> Products { get; private set; }
        [ForeignKey(nameof(Restaurant))]
        
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; private set; }

    }
}