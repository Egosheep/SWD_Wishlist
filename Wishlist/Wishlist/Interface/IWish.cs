namespace Wishlist.Interface
{
    public interface IWish
    {
        string Name { get; set; }
        double Price { get; set; }
        string ToString();
    }
}