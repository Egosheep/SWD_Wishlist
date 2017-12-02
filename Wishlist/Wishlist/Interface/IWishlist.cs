using System;
using System.Collections.Generic;

namespace Wishlist.Interface
{
    public interface IWishlist
    {
        string OwnerName { get; set; }
        string OwnerAddress { get; set; }
        List<IWish> ListOfWishes { get; set;}
        string State { get; set; }

        void RestoreToDefault(IMemento defaultMemento);
        void RestoreToCheckpoint(IMemento checkpointMemento);
        void AddWish();
        void PrintWishlist();
        void RemoveWish();
        void ClearWishlist();
        double TotalWishlistPrice();

    }
}