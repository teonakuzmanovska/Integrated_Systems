using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace is_aud1.Models
{
    // data stransfer object - not included in the database,
    // just passes data between controller-view or model-view

    public class AddToShoppingCartDto
    {
        public Product SelectedProduct { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
