using Wishlist.Interface;

namespace Wishlist.Classes
{
    public class CheckpointMemento : IMemento
    {
        public CheckpointMemento(string state)
        {
            State = state;
        }
        public string State { get; set; }
    }
}