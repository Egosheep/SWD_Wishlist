using System;
using Wishlist.Interface;

namespace Wishlist
{
    public class ConsolePrinter : IConsolePrinter
    {
        public void CenteredHeader(string text)
        {
            string headerText = text;
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (headerText.Length / 2)) + "}", headerText);
        }

        public void MenuItem(string itemName, string text)
        {
            Console.WriteLine("(" + itemName + ")" + "\t " + text);
        }
    }
}