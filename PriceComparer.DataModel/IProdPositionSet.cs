﻿using System.Collections.Generic;
using System.Drawing;

namespace PriceComparer.DataModel
{
    public interface IProdPositionSet
    {
        string Name { get; set; }
        Color TileColor { get; set; }
        List<IProdPosition> ProductPositions { get; set; }
    }
}
