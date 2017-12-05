using System;
using Wishlist.Interface;

namespace Wishlist
{
    [Serializable]
    public class Wish : IWish
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return "Wish name: " + Name + ".\t Price: " + Price + " BTC.";
        }
    }
}