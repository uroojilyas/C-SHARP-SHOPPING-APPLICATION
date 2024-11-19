using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_PROJECT
{
    public class SharedCart
    {
        // Shared list of CartItem items
        public static List<CartItem> Items { get; set; } = new List<CartItem>();
    }
}
