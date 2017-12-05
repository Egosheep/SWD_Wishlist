// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IConsolePrinter.cs" company="Aarhus University">
//   Group 1
// </copyright>
// <summary>
//   Defines the IConsolePrinter type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wishlist.Interface
{
    /// <summary>
    /// The ConsolePrinter interface.
    /// </summary>
    public interface IConsolePrinter
    {
        /// <summary>
        /// The print centered header.
        /// </summary>
        /// <param name="text">
        /// The text.
        /// </param>
        void PrintCenteredHeader(string text);

        /// <summary>
        /// The print main menu wish list item.
        /// </summary>
        /// <param name="itemNumber">
        /// The item number.
        /// </param>
        /// <param name="item">
        /// The item.
        /// </param>
        void PrintMainMenuWishlistItem(int itemNumber, IWishlist item);
    }
}