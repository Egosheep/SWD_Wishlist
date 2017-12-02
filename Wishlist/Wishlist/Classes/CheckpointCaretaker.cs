using Wishlist.Interface;

namespace Wishlist.Classes
{
    public class CheckpointCaretaker : ICaretaker
    {
        public IMemento Memento { get; set; }
    }
}