using System;

namespace GeekStore.Domain.Model.Components
{
    public class Display : Entity
    {
        public Display() { }

        public Display(string aspectRatio, int maxRefreshRate, string resolution, decimal size)
        {
            if (string.IsNullOrEmpty(aspectRatio.Trim())) throw new ArgumentNullException(nameof(aspectRatio));
            if (maxRefreshRate < 60) throw new ArgumentException($"Display Max Refresh Rate cannot be less than 60Hz. Entered value: {maxRefreshRate}");
            if (string.IsNullOrEmpty(resolution.Trim())) throw new ArgumentNullException(nameof(resolution));
            if (size <= 0) throw new ArgumentException($"Display size cannot be less or equal to 0. Entered value: {size}");

            AspectRatio = aspectRatio;
            MaxRefreshRate = maxRefreshRate;
            Resolution = resolution;
            Size = size;
        }

        public virtual string AspectRatio { get; protected set; }
        public virtual int MaxRefreshRate { get; protected set; }
        public virtual string Resolution { get; protected set; }
        public virtual decimal Size { get; protected set; }

        public override string ToString()
        {
            return $"{AspectRatio} {Resolution} @ {MaxRefreshRate}Hz";
        }
    }
}