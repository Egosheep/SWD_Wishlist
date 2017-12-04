using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wishlist
{
    using global::Wishlist.Interface;

    class Program
    {
        static void Main(string[] args)
        {
            var WishList = new Wishlist();
            WishList.OwnerAddress = "her";
            WishList.OwnerName = "toby";
            WishList.ListOfWishes = new List<IWish>();
            var WishListMenu = new WishlistMenu(WishList);
            WishListMenu.ShowWishlistMenu();
        }
    }
}
