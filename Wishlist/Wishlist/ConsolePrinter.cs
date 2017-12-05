using System;
using Wishlist.Interface;

namespace Wishlist
{
    public class ConsolePrinter : IConsolePrinter
    {
        public void PrintCenteredHeader(string text)
        {
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text);
        }

        public void PrintMainMenuWishlistItem(int itemNumber, IWishlist item)
        {
            Console.WriteLine("(" + itemNumber + ")" + "\t " + item.OwnerName + "' Wishlist.");
        }
    }
}