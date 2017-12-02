using Wishlist.Interface;

namespace Wishlist.Classes
{
    public class DefaultMemento : IMemento
    {
        public DefaultMemento(string state)
        {
            State = state;
        }
        public string State { get; set; }
    }
}