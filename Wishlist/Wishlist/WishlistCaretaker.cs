// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WishlistCaretaker.cs" company="Aarhus University">
//   Group 1
// </copyright>
// <summary>
//   Defines the WishlistCaretaker type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wishlist
{
    using global::Wishlist.Interface;

    /// <summary>
    /// The wish list caretaker.
    /// </summary>
    public class WishlistCaretaker : IWishlistCaretaker
    {
        /// <summary>
        /// Gets or sets the wish list memento.
        /// </summary>
        public IWishlistMemento WishlistMemento { get; set; }
    }
}