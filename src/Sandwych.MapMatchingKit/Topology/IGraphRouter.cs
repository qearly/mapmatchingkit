﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sandwych.MapMatchingKit.Topology
{
    public interface IGraphRouter<TEdge, TPoint>
        where TEdge : IGraphEdge
        where TPoint : IEdgePoint<TEdge>
    {
        bool TryRoute(in TPoint startPoint, in TPoint endPoint, out IEnumerable<TEdge> path);
    }

}