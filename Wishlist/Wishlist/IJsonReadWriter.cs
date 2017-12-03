using System.Collections.Generic;
using Wishlist.Interface;

namespace Wishlist
{
    public interface IJsonReadWriter
    {
        Dictionary<int, IWishlist> LoadWishlistsFromFile();
        void SaveWishlistToFile(Dictionary<int, IWishlist> wishhlistsToSave);
    }
}