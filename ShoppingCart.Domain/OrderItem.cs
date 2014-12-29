using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Domain
{
    public class OrderItem
    {
        /// <summary>
        /// Los números SKU (por sus iniciales en inglés) son códigos de "Unidad de mantenimiento de stock", 
        /// que permiten a una empresa identificar los productos o materiales en el inventario. 
        /// Las tiendas los utilizan para realizar un seguimiento de los artículos para la venta.
        /// </summary>
        public string Sku { get; set; }

        public int Quantity { get; set; }
    }
}
