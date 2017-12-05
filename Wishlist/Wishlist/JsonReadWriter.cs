using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
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
            try
            {
                var tempList = JsonConvert.DeserializeObject<List<IWishlist>>(File.ReadAllText(_filepath), new JsonSerializerSettings()
                {
                    TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Objects,
                    NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
                });
                var key = 0;
                foreach (var wishlist in tempList)
                {
                    key++;
                    returnDictionary.Add(key, wishlist);
                }
                return returnDictionary;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                Console.WriteLine("No file found.");
                Thread.Sleep(1000);
                return null;
            }
        }

        public void SaveWishlistToFile(Dictionary<int, IWishlist> wishlistsToSave)
        {
            if (wishlistsToSave == null || wishlistsToSave.Count < 1)
            {
                return;
            }
            var wishlistList = wishlistsToSave.Values.ToList();
            File.WriteAllText(_filepath, JsonConvert.SerializeObject(wishlistList, Formatting.Indented,
                new JsonSerializerSettings
                {
                NullValueHandling = NullValueHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Objects
                })
            );
        }
    }
}