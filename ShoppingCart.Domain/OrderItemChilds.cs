using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Domain
{
    public class OrderItemPeso : OrderItem, Item
    {
        public decimal subtotal(decimal sumaParcial)
        {
            // cantidad en gramos, el precio es por kg
            return sumaParcial + Quantity * 4m / 1000;
        }
    }

    public class OrderItemUnidad : OrderItem, Item
    {
        public decimal subtotal(decimal sumaParcial)
        {
            return sumaParcial + Quantity * 5m;
        }
    }

    public class OrderItemEspacial : OrderItem, Item
    {
        public decimal subtotal(decimal sumaParcial)
        {
            // $1.40 cada uno; 3 por $4.00
            var resultado = sumaParcial += Quantity * 1.4m;
            int grupodetres = Quantity / 3;
            resultado -= grupodetres * 0.2m;

            return resultado;
        }
    }
}
