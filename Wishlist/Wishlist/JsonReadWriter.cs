using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Wishlist.Interface;

namespace Wishlist
{
    public class JsonReadWriter : IJsonReadWriter
    {
        private readonly string _filepath = AppDomain.CurrentDomain.BaseDirectory + "\\localstore_wishlists.json";

        public Dictionary<int, IWishlist> LoadWishlistsFromFile()
        {
            var returnDictionary = new Dictionary<int, IWishlist>();
            var tempList = new List<IWishlist>();
            tempList = JsonConvert.DeserializeObject<List<IWishlist>>(File.ReadAllText(_filepath));
            int key = 0;
            foreach (var wishlist in tempList)
            {
                key++;
                returnDictionary.Add(key, wishlist);
            }
            return returnDictionary;
        }

        public void SaveWishlistToFile(Dictionary<int, IWishlist> wishlistsToSave)
        {
            var wishlistList = wishlistsToSave.ToList();
            File.WriteAllText(_filepath, JsonConvert.SerializeObject(wishlistList));
        }
    }
}