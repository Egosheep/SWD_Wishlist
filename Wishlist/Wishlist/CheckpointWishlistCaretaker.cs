using Wishlist.Interface;

namespace Wishlist
{
    public class CheckpointWishlistCaretaker : IWishlistCaretaker
    {
        public IWishlistMemento WishlistMemento { get; set; }
    }
}