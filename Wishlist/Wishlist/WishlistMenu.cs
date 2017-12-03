using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Wishlist.Interface;

namespace Wishlist
{
    public class WishlistMenu : IWishlistMenu
    {
        public Dictionary<int, IWishlist> WishlistDictionary { get; set; }

        public WishlistMenu()
        {
            var jsonReadWriter = new JsonReadWriter();
        }

        public void ShowWishlistMenu()
        {
            throw new System.NotImplementedException();
        }
    }
}