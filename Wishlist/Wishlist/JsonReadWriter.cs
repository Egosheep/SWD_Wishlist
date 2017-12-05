// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JsonReadWriter.cs" company="Aarhus University">
//   Group 1
// </copyright>
// <summary>
//   Defines the JsonReadWriter type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wishlist
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Threading;

    using global::Wishlist.Interface;

    using Newtonsoft.Json;

    /// <summary>
    /// The JSon read writer.
    /// </summary>
    public class JsonReadWriter : IJsonReadWriter
    {
        /// <summary>
        /// The _filepath.
        /// </summary>
        private readonly string _filepath = AppDomain.CurrentDomain.BaseDirectory + "\\localstore_wishlists.json";

        /// <summary>
        /// The load wish lists from file.
        /// </summary>
        /// <returns>
        /// The <see cref="Dictionary"/>.
        /// </returns>
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

        /// <summary>
        /// The save wish list to file.
        /// </summary>
        /// <param name="wishlistsToSave">
        /// The wish lists to save.
        /// </param>
        public void SaveWishlistToFile(Dictionary<int, IWishlist> wishlistsToSave)
        {
            if (wishlistsToSave == null || wishlistsToSave.Count < 1)
            {
                return;
            }
            var wishlistList = wishlistsToSave.Values.ToList();
            File.WriteAllText(
                this._filepath,
                JsonConvert.SerializeObject(
                    wishlistList,
                    Formatting.Indented,
                    new JsonSerializerSettings
                        {
                NullValueHandling = NullValueHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Objects
                        }));
        }
    }
}