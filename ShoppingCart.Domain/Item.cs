using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Domain
{
    public interface Item
    {
        decimal subtotal(decimal sumaParcial);
    }
}
