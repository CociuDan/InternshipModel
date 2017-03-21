﻿using System;

namespace GeekStore.Model.Components
{
    public class Display
    {
        public Display(string aspectRatio, int maxRefreshRate, string resolution, double size)
        {

            if (string.IsNullOrEmpty(aspectRatio.Trim()))
                throw new ArgumentNullException(nameof(aspectRatio));

            if (maxRefreshRate < 60)
                throw new ArgumentException($"Display Max Refresh Rate cannot be less than 60Hz. Entered value: {maxRefreshRate}");

            if (string.IsNullOrEmpty(resolution.Trim()))
                throw new ArgumentNullException(nameof(resolution));

            if (size <= 0)
                throw new ArgumentException($"Display size cannot be less or equal to 0. Entered value: {size}");

            AspectRatio = aspectRatio;
            MaxRefreshRate = maxRefreshRate;
            Resolution = resolution;
            Size = size;
        }

        public string AspectRatio { get; }
        public int MaxRefreshRate { get; }
        public string Resolution { get; }
        public double Size { get; }
    }
}