// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWishlist.cs" company="Aarhus University">
//   Group 1
// </copyright>
// <summary>
//   Defines the IWishlist type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wishlist.Interface
{
    using System.Collections.Generic;

    /// <summary>
    /// The Wish list interface.
    /// </summary>
    public interface IWishlist
    {
        /// <summary>
        /// Gets or sets the owner name.
        /// </summary>
        string OwnerName { get; set; }

        /// <summary>
        /// Gets or sets the owner address.
        /// </summary>
        string OwnerAddress { get; set; }

        /// <summary>
        /// Gets or sets the list of wishes.
        /// </summary>
        List<IWish> ListOfWishes { get; set;}

        /// <summary>
        /// The store memento.
        /// </summary>
        /// <returns>
        /// The <see cref="WishlistMemento"/>.
        /// </returns>
        WishlistMemento StoreMemento();

        /// <summary>
        /// The restore to default.
        /// </summary>
        /// <param name="defaultWishlistMemento">
        /// The default wish list memento.
        /// </param>
        void RestoreToDefault(IWishlistMemento defaultWishlistMemento);

        /// <summary>
        /// The restore to checkpoint.
        /// </summary>
        /// <param name="checkpointWishlistMemento">
        /// The checkpoint wish list memento.
        /// </param>
        void RestoreToCheckpoint(IWishlistMemento checkpointWishlistMemento);

        /// <summary>
        /// The add wish.
        /// </summary>
        void AddWish();

        /// <summary>
        /// The print wish list.
        /// </summary>
        void PrintWishlist();

        /// <summary>
        /// The remove wish.
        /// </summary>
        /// <param name="wishName">
        /// The wish name.
        /// </param>
        void RemoveWish(string wishName);

        /// <summary>
        /// The clear wish list.
        /// </summary>
        void ClearWishlist();

        /// <summary>
        /// The total wish list price.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        double TotalWishlistPrice();
    }
}