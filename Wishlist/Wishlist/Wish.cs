// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Wish.cs" company="Aarhus University">
//   Group 1
// </copyright>
// <summary>
//   Defines the Wish type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Wishlist
{
    using System;

    using global::Wishlist.Interface;

    /// <summary>
    /// The wish.
    /// </summary>
    [Serializable]
    public class Wish : IWish
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return "Wish name: " + Name + ".\t Price: " + Price + " BTC.";
        }
    }
}