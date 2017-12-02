using System;
using System.Collections.Generic;

namespace Wishlist.Interface
{
    public interface IWishlist
    {
        string OwnerName { get; set; }
        string OwnerAddress { get; set; }
        List<IWish> ListOfWishes { get; set;}

        DefaultMemento StoreDefaultMemento();
        void RestoreToDefault(IMemento defaultMemento);
        CheckpointMemento StoreCheckpointMemento();
        void RestoreToCheckpoint(IMemento checkpointMemento);
        void AddWish();
        void PrintWishlist();
        void RemoveWish(string wishName);
        void ClearWishlist();
        double TotalWishlistPrice();

    }
}