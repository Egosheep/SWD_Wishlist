using System.Collections.Generic;
using Wishlist.Interface;

namespace Wishlist
{
    public interface IJsonReadWriter
    {
        Dictionary<int, IWishlist> LoadWishlists();
        void SaveWishlistToFile(Dictionary<int, IWishlist> wishhlistsToSave);
    }
}