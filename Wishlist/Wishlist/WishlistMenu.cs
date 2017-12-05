using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Newtonsoft.Json;
using Wishlist.Interface;

namespace Wishlist
{
    public class WishlistMenu : IWishlistMenu
    {
        private IWishlist _wishlist;
        private IWishlistCaretaker _checkpointCaretaker;
        private IWishlistCaretaker _defaultCaretaker;

        public WishlistMenu(IWishlist chosenWishlist)
        {
            _wishlist = chosenWishlist;
            _checkpointCaretaker = new WishlistCaretaker();
            this._defaultCaretaker = new WishlistCaretaker();
            _defaultCaretaker.WishlistMemento = chosenWishlist.StoreMemento();
        }

        public void ShowWishlistMenu()
        {
            var readLine = string.Empty;
            while ((readLine.ToLower() != "e" && readLine.ToLower() != "s") || string.IsNullOrEmpty(readLine))
            {
                Console.Clear();
                foreach (var wish in _wishlist.ListOfWishes)
                {
                    Console.WriteLine(wish.ToString());
                }
                WishlistMenuOptions();
                readLine = Console.ReadLine();
                switch (readLine.ToLower())
                {
                    case "a":
                        _checkpointCaretaker.WishlistMemento = _wishlist.StoreMemento();
                        _wishlist.AddWish();
                        break;
                    case "r":
                        _checkpointCaretaker.WishlistMemento = _wishlist.StoreMemento();
                        Console.WriteLine("Enter name of wish to delete: ");
                        _wishlist.RemoveWish(Console.ReadLine());
                        break;
                    case "c":
                        _wishlist.RestoreToDefault(_defaultCaretaker.WishlistMemento);
                        break;
                    case "u":
                        _wishlist.RestoreToCheckpoint(_checkpointCaretaker.WishlistMemento);
                        break;
                    case "e":
                        _wishlist.RestoreToDefault(_defaultCaretaker.WishlistMemento);
                        break;
                    case "s":
                        Console.WriteLine("Saving and exiting.");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("That's not an option dumbass.");
                        break;
                }
            }
        }

        private void WishlistMenuOptions()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("(A)dd wish.\t (R)emove wish.\t (C)lear wishlist.");
            Console.WriteLine("(U)ndo last change.\t (E)xit and undo all changes.\t (S)ave and exit.");
        }
    }
}