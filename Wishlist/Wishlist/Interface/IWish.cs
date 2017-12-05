// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWish.cs" company="Aarhus University">
//   Group 1
// </copyright>
// <summary>
//   Defines the IWish type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wishlist.Interface
{
    /// <summary>
    /// The Wish interface.
    /// </summary>
    public interface IWish
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        double Price { get; set; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string ToString();
    }
}