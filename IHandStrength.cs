using System;
using System.Collections.Generic;

namespace SnapCall
{
    public interface IHandStrength : IComparable<IHandStrength>
    {
        HandRanking HandRanking { get; set; }
        IList<int> Kickers { get; set; }
    }
}