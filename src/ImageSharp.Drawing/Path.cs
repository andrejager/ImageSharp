﻿// <copyright file="Path.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.Drawing
{
    /// <summary>
    /// Represents a something that has knowledge about its outline.
    /// </summary>
    public abstract class Path
    {
        /// <summary>
        /// Gets the maximum number of intersections to could be returned.
        /// </summary>
        /// <value>
        /// The maximum intersections.
        /// </value>
        public abstract int MaxIntersections { get; }

        /// <summary>
        /// Gets the bounds.
        /// </summary>
        /// <value>
        /// The bounds.
        /// </value>
        public abstract Rectangle Bounds { get; }

        /// <summary>
        /// Gets the point information for the specified x and y location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Information about the point in relation to a drawable edge</returns>
        public abstract PointInfo GetPointInfo(int x, int y);

        /// <summary>
        /// Scans the X axis for intersections.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="buffer">The buffer.</param>
        /// <param name="length">The length.</param>
        /// <param name="offset">The offset.</param>
        /// <returns>The number of intersections found.</returns>
        public abstract int ScanX(int x, float[] buffer, int length, int offset);

        /// <summary>
        /// Scans the Y axis for intersections.
        /// </summary>
        /// <param name="y">The position along the y axis to find intersections.</param>
        /// <param name="buffer">The buffer.</param>
        /// <param name="length">The length.</param>
        /// <param name="offset">The offset.</param>
        /// <returns>The number of intersections found.</returns>
        public abstract int ScanY(int y, float[] buffer, int length, int offset);
    }
}