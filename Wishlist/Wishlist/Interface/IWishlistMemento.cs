// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWishlistMemento.cs" company="Aarhus University">
//   Group 1
// </copyright>
// <summary>
//   Defines the IWishlistMemento type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wishlist.Interface
{
    using System.Collections.Generic;

    /// <summary>
    /// The Wish list Memento interface.
    /// </summary>
    public interface IWishlistMemento
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
        List<IWish> ListOfWishes { get; set; }
    }
}