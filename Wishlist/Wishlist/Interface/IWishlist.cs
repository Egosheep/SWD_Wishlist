using System;
using System.Collections.Generic;

namespace Wishlist.Interface
{
    public interface IWishlist
    {
        string OwnerName { get; set; }
        string OwnerAddress { get; set; }
        List<IWish> ListOfWishes { get; set;}

        DefaultWishlistMemento StoreDefaultMemento();
        void RestoreToDefault(IWishlistMemento defaultWishlistMemento);
        CheckpointWishlistMemento StoreCheckpointMemento();
        void RestoreToCheckpoint(IWishlistMemento checkpointWishlistMemento);
        void AddWish();
        void PrintWishlist();
        void RemoveWish(string wishName);
        void ClearWishlist();
        double TotalWishlistPrice();

    }
}