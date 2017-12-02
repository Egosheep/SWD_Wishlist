using System.Collections.Generic;

namespace Wishlist.Interface
{
    public interface IWishlistMemento
    {
        string OwnerName { get; set; }
        string OwnerAddress { get; set; }
        List<IWish> ListOfWishes { get; set; }
    }
}