using System.Collections.Generic;

namespace SnapCall
{
    public interface IDeck
    {
        IEnumerable<ICard> Draw(int count);
        void RefillAndShuffle();
    }
}