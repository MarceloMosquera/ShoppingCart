using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Domain
{

    public class Cart
    {
        private List<OrderItem> _items;

        public Cart()
        {
            _items = new List<OrderItem>();
        }

        public string MailCliente { get; set; }

        public IEnumerable<OrderItem> Items
        {
            get { return _items; }
        }

        public void Add(OrderItem orderItem)
        {
            _items.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0m;
            foreach (OrderItem orderItem in Items)
            {
                if (orderItem.Sku.StartsWith("U")) //Unidad
                {
                    total += orderItem.Quantity * 5m;
                }
                else if (orderItem.Sku.StartsWith("P")) //Peso
                {
                    // cantidad en gramos, el precio es por kg
                    total += orderItem.Quantity * 4m / 1000;
                } 
                else if (orderItem.Sku.StartsWith("E")) //Espacial
                { 
                    // $1.40 cada uno; 3 por $4.00
                    total += orderItem.Quantity * 1.4m;
                    int grupodetres = orderItem.Quantity / 3;
                    total -= grupodetres * 0.2m;
                }

                // mas reglas
            }

            return total;

        }

    }



}
