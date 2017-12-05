// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWishlistCaretaker.cs" company="Aarhus University">
//   Group 1
// </copyright>
// <summary>
//   Defines the IWishlistCaretaker type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wishlist.Interface
{
    /// <summary>
    /// The Wish list Caretaker interface.
    /// </summary>
    public interface IWishlistCaretaker
    {
        /// <summary>
        /// Gets or sets the wish list memento.
        /// </summary>
        IWishlistMemento WishlistMemento { get; set; }
    }
}