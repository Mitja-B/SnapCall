using System.Collections.Generic;

namespace SnapCall
{
    public interface IHand : ICollection<ICard>
    {
        HandStrength GetStrength();
    }
}