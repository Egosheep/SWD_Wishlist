using Wishlist.Interface;

namespace Wishlist
{
    public class DefaultWishlistCaretaker : IWishlistCaretaker
    {
        public IWishlistMemento WishlistMemento { get; set; }
    }
}