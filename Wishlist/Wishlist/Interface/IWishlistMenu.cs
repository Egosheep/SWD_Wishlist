using System.Collections.Generic;

namespace Wishlist.Interface
{
    public interface IWishlistMenu
    {
        Dictionary<int, IWishlist> WishlistDictionary{ get; set; }
        void ShowWishlistMenu();

    }
}