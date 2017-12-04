namespace Wishlist.Interface
{
    public interface IConsolePrinter
    {
        void CenteredHeader(string text);
        void MenuItem(string itemName, string text);
    }
}