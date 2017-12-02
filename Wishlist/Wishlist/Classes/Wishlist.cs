using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.Write("Wish name: ");
            string wishName = null;
            while (string.IsNullOrEmpty(wishName))
            {
                wishName = Console.ReadLine();
            }
            Console.Write("Wish price: ");
            string wishPrice = null;
            while (string.IsNullOrEmpty(wishPrice))
            {
                wishPrice = Console.ReadLine();
            }
            var newWish = new Wish()
            {
                Name = wishName,
                Price = double.Parse(wishPrice)
            };
            ListOfWishes.Add(newWish);
            Console.WriteLine("Wish added to wishlist.");
        }

        public void PrintWishlist()
        {
            foreach (var wish in ListOfWishes)
            {
                Console.WriteLine(wish.ToString());
            }
        }

        public void RemoveWish(string wishName)
        {
            var wishesToRemove = ListOfWishes.Where(f => f.Name.Contains(wishName));
            foreach (var wish in wishesToRemove)
            {
                Console.WriteLine("Remove " + wish.Name + " from wishlist?");
                Console.WriteLine("Y/N");
                var removeAnswer = Console.ReadLine();
                if (removeAnswer != "Y") continue;
                ListOfWishes.Remove(wish);
                Console.WriteLine(wish.Name + " Removed from wishlist.");
            }
        }

        public void ClearWishlist()
        {
            ListOfWishes.Clear();
            Console.WriteLine("Wishlist cleared.");
        }

        public double TotalWishlistPrice()
        {
            return ListOfWishes.Sum(wish => wish.Price);
        }
    }
}