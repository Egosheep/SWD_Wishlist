// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IJsonReadWriter.cs" company="Aarhus University">
//   Group 1
// </copyright>
// <summary>
//   Defines the IJsonReadWriter type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wishlist.Interface
{
    using System.Collections.Generic;

    /// <summary>
    /// The JSon Read Writer interface.
    /// </summary>
    public interface IJsonReadWriter
    {
        /// <summary>
        /// The load wish lists from file.
        /// </summary>
        /// <returns>
        /// The <see cref="Dictionary"/>.
        /// </returns>
        Dictionary<int, IWishlist> LoadWishlistsFromFile();

        /// <summary>
        /// The save wish list to file.
        /// </summary>
        /// <param name="wishlistsToSave">
        /// The wish lists to save.
        /// </param>
        void SaveWishlistToFile(Dictionary<int, IWishlist> wishlistsToSave);
    }
}