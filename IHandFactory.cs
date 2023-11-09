using System.Collections.Generic;

namespace SnapCall
{
    public interface IHandFactory
    {
        IHand Create();
        IHand Create(IEnumerable<ICard> cards);
        IHand Create(ulong bitmap);
    }
}
