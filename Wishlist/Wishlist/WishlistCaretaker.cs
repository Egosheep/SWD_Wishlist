using Wishlist.Interface;

namespace Wishlist
{
    public class WishlistCaretaker : IWishlistCaretaker
    {
        public IWishlistMemento WishlistMemento { get; set; }
    }
}