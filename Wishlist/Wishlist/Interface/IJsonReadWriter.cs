using System.Collections.Generic;

namespace Wishlist.Interface
{
    public interface IJsonReadWriter
    {
        Dictionary<int, IWishlist> LoadWishlistsFromFile();
        void SaveWishlistToFile(Dictionary<int, IWishlist> wishhlistsToSave);
    }
}