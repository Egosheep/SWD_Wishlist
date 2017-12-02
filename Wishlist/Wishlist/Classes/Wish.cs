using Wishlist.Interface;

namespace Wishlist.Classes
{
    public class Wish : IWish
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}