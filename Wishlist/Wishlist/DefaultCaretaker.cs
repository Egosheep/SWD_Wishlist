using Wishlist.Interface;

namespace Wishlist
{
    public class DefaultCaretaker : ICaretaker
    {
        public IMemento Memento { get; set; }
    }
}