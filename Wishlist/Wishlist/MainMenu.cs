// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainMenu.cs" company="Aarhus University">
//   Group 1
// </copyright>
// <summary>
//   Defines the MainMenu type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wishlist
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Mime;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    using global::Wishlist.Interface;

    /// <summary>
    /// The main menu.
    /// </summary>
    public class MainMenu
    {
        /// <summary>
        /// The _console printer.
        /// </summary>
        private readonly IConsolePrinter _consolePrinter;

        /// <summary>
        /// The _wishlist menu.
        /// </summary>
        private IWishlistMenu _wishlistMenu;

        /// <summary>
        /// The _json read writer.
        /// </summary>
        private readonly IJsonReadWriter _jsonReadWriter;

        /// <summary>
        /// The wish list dictionary.
        /// </summary>
        private Dictionary<int, IWishlist> _wishlistDictionary;

        /// <summary>
        /// The main.
        /// </summary>
        public static void Main()
        {
            var mainMenu = new MainMenu();
            mainMenu.ShowMainMenu();
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="MainMenu"/> class from being created.
        /// </summary>
        private MainMenu()
        {
            _consolePrinter = new ConsolePrinter();
            _jsonReadWriter = new JsonReadWriter();
            _wishlistDictionary = _jsonReadWriter.LoadWishlistsFromFile() ?? new Dictionary<int, IWishlist>();
        }

        /// <summary>
        /// The show main menu.
        /// </summary>
        private void ShowMainMenu()
        {
            var input = string.Empty;
            while (true)
            {
                Console.Clear();
                _consolePrinter.PrintCenteredHeader("Main Menu");
                if (_wishlistDictionary != null)
                {
                    foreach (KeyValuePair<int, IWishlist> wishlist in _wishlistDictionary)
                    {
                        _consolePrinter.PrintMainMenuWishlistItem(wishlist.Key, wishlist.Value);
                    }
                }
                else
                {
                    Console.WriteLine("No wishlists to show.");
                }
                MainMenuOption();
                input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "a":
                        _wishlistDictionary.Add(_wishlistDictionary.Count+1, AddWishlist());
                        _wishlistMenu = new WishlistMenu(_wishlistDictionary.Last().Value);
                        _wishlistMenu.ShowWishlistMenu();
                        break;
                    case "e":
                        _jsonReadWriter.SaveWishlistToFile(_wishlistDictionary);
                        Environment.Exit(0);
                        break;
                    default:
                        if (Regex.IsMatch(input, @"^[0-9]+$"))
                        {
                            _wishlistMenu = new WishlistMenu(_wishlistDictionary[int.Parse(input)]);
                            _wishlistMenu.ShowWishlistMenu();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Input is not a number or valid option.");
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// The main menu option.
        /// </summary>
        private void MainMenuOption()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Enter the number of wishlist to edit or choose another option.");
            Console.WriteLine("(A)dd Wishlist.\t (E)xit Wishlist Manager.");
        }

        /// <summary>
        /// The add wish list.
        /// </summary>
        /// <returns>
        /// The <see cref="IWishlist"/>.
        /// </returns>
        private IWishlist AddWishlist()
        {
            Console.WriteLine();
            Console.Write("Owner name: ");
            var newName = Console.ReadLine();
            Console.Write("Owner address: ");
            var newAddress = Console.ReadLine();
            return new Wishlist(newName, newAddress);
        }
    }
}
