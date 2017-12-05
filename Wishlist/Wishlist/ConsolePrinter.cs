// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsolePrinter.cs" company="Aarhus University">
//   Group 1
// </copyright>
// <summary>
//   Defines the ConsolePrinter type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wishlist
{
    using System;

    using global::Wishlist.Interface;

    /// <summary>
    /// The console printer.
    /// </summary>
    public class ConsolePrinter : IConsolePrinter
    {
        /// <summary>
        /// The print centered header.
        /// </summary>
        /// <param name="text">
        /// The text.
        /// </param>
        public void PrintCenteredHeader(string text)
        {
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text);
        }

        /// <summary>
        /// The print main menu wish list item.
        /// </summary>
        /// <param name="itemNumber">
        /// The item number.
        /// </param>
        /// <param name="item">
        /// The item.
        /// </param>
        public void PrintMainMenuWishlistItem(int itemNumber, IWishlist item)
        {
            Console.WriteLine("(" + itemNumber + ")" + "\t " + item.OwnerName + "' Wishlist.");
        }
    }
}