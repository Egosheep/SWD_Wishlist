using Wishlist.Interface;

namespace Wishlist.Classes
{
    public class DefaultCaretaker : ICaretaker
    {
        public IMemento Memento { get; set; }
    }
}