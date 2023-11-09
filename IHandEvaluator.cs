using System.Collections.Generic;

namespace SnapCall
{
    public interface IHandEvaluator
    {
        int Evaluate(IEnumerable<ICard> cards);
    }
}