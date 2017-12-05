namespace Wishlist.Interface
{
    public interface IConsolePrinter
    {
        void PrintCenteredHeader(string text);
        void PrintMainMenuWishlistItem(int itemNumber, IWishlist item);
    }
}