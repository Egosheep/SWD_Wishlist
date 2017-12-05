// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Wishlist.cs" company="Aarhus University">
//   Group 1
// </copyright>
// <summary>
//   Defines the Wishlist type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wishlist
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using global::Wishlist.Interface;

    /// <summary>
    /// The wishlist.
    /// </summary>
    [Serializable]
    public class Wishlist : IWishlist
    {
        /// <summary>
        /// Gets or sets the owner name.
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or sets the owner address.
        /// </summary>
        public string OwnerAddress { get; set; }

        /// <summary>
        /// Gets or sets the list of wishes.
        /// </summary>
        public List<IWish> ListOfWishes { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wishlist"/> class.
        /// </summary>
        /// <param name="owner">
        /// The owner.
        /// </param>
        /// <param name="address">
        /// The address.
        /// </param>
        public Wishlist(string owner, string address)
        {
            OwnerName = owner;
            OwnerAddress = address;
            ListOfWishes = new List<IWish>();
        }

        /// <summary>
        /// The store memento.
        /// </summary>
        /// <returns>
        /// The <see cref="WishlistMemento"/>.
        /// </returns>
        public WishlistMemento StoreMemento()
        {
            return new WishlistMemento(this);
        }

        /// <summary>
        /// The restore to default.
        /// </summary>
        /// <param name="defaultWishlistMemento">
        /// The default wish list memento.
        /// </param>
        public void RestoreToDefault(IWishlistMemento defaultWishlistMemento)
        {
            OwnerName = defaultWishlistMemento.OwnerName;
            OwnerAddress = defaultWishlistMemento.OwnerAddress;
            ListOfWishes = defaultWishlistMemento.ListOfWishes;
        }

        /// <summary>
        /// The restore to checkpoint.
        /// </summary>
        /// <param name="checkpointWishlistMemento">
        /// The checkpoint wish list memento.
        /// </param>
        public void RestoreToCheckpoint(IWishlistMemento checkpointWishlistMemento)
        {
            if (checkpointWishlistMemento != null)
            {
                OwnerName = checkpointWishlistMemento.OwnerName;
                OwnerAddress = checkpointWishlistMemento.OwnerAddress;
                ListOfWishes = checkpointWishlistMemento.ListOfWishes;
            }
        }

        /// <summary>
        /// The add wish.
        /// </summary>
        public void AddWish()
        {
            Console.Clear();
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

        /// <summary>
        /// The print wishlist.
        /// </summary>
        public void PrintWishlist()
        {
            foreach (var wish in ListOfWishes)
            {
                Console.WriteLine(wish.ToString());
            }
        }

        /// <summary>
        /// The remove wish.
        /// </summary>
        /// <param name="wishName">
        /// The wish name.
        /// </param>
        public void RemoveWish(string wishName)
        {
            Console.Clear();
            var wishesToRemove = ListOfWishes.Where(f => f.Name.Contains(wishName));
            if (wishesToRemove.Count() == 0)
            {
                Console.WriteLine("Not found");
            }
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

        /// <summary>
        /// The clear wishlist.
        /// </summary>
        public void ClearWishlist()
        {
            ListOfWishes.Clear();
            Console.WriteLine("Wishlist cleared.");
        }

        /// <summary>
        /// The total wishlist price.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public double TotalWishlistPrice()
        {
            return ListOfWishes.Sum(wish => wish.Price);
        }
    }
}