using System.Collections.Generic;
using Wishlist.Interface;

namespace Wishlist.Classes
{
    public class Wishlist : IWishlist
    {
        public string OwnerName { get; set; }
        public string OwnerAddress { get; set; }
        public List<IWish> ListOfWishes { get; set; }
        public string State { get; set; }
        public void RestoreToDefault(IMemento defaultMemento)
        {
            throw new System.NotImplementedException();
        }

        public void RestoreToCheckpoint(IMemento checkpointMemento)
        {
            throw new System.NotImplementedException();
        }

        public void AddWish()
        {
            throw new System.NotImplementedException();
        }

        public void PrintWishlist()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveWish()
        {
            throw new System.NotImplementedException();
        }

        public void ClearWishlist()
        {
            throw new System.NotImplementedException();
        }

        public double TotalWishlistPrice()
        {
            throw new System.NotImplementedException();
        }
    }
}