using System;
using System.Collections;

namespace Carry_In.Pages.Cart.Models
{
    [Serializable()]
    public class ShoppingCart : CollectionBase
    {
        public ShoppingCartItem this[int index]
        {
            get { return ((ShoppingCartItem)List[index]); }
            set { List[index] = value; }
        }
        public int Add(ShoppingCartItem value)
        {
            return (List.Add(value));
        }
        public int IndexOf(ShoppingCartItem value)
        {
            return (List.IndexOf(value));
        }
        public void Insert(int index, ShoppingCartItem value)
        {
            List.Insert(index, value);
        }
        public void Remove(ShoppingCartItem value)
        {
            List.Remove(value);
        }
        public bool Contains(ShoppingCartItem value)
        {
            return (List.Contains(value));
        }
    }
}
