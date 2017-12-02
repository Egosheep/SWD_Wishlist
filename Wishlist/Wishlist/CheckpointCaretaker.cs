using Wishlist.Interface;

namespace Wishlist
{
    public class CheckpointCaretaker : ICaretaker
    {
        public IMemento Memento { get; set; }
    }
}