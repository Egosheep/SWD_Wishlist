// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WishlistMemento.cs" company="Aarhus University">
//   Group 1
// </copyright>
// <summary>
//   Defines the WishlistMemento type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wishlist
{
    using System.Collections.Generic;

    using global::Wishlist.Interface;

    /// <summary>
    /// The wishlist memento.
    /// </summary>
    public class WishlistMemento : IWishlistMemento
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WishlistMemento"/> class.
        /// </summary>
        /// <param name="wishlist">
        /// The wish list.
        /// </param>
        public WishlistMemento(IWishlist wishlist)
        {
            OwnerAddress = wishlist.OwnerAddress;
            OwnerName = wishlist.OwnerName;
            if(wishlist.ListOfWishes != null)
            ListOfWishes = new List<IWish>(wishlist.ListOfWishes);
        }

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
    }
}