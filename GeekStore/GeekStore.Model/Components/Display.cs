using System;

namespace GeekStore.Model.Components
{
    public class Display
    {
        public Display(string aspectRatio, int maxRefreshRate, string resolution, double size)
        {
            try
            {
                if (string.IsNullOrEmpty(aspectRatio) || string.IsNullOrWhiteSpace(aspectRatio))
                    throw new ArgumentNullException("aspectRatio");

                if (maxRefreshRate < 60)
                    throw new ArgumentException($"Display Max Refresh Rate cannot be less than 60Hz. Entered value: {maxRefreshRate}");

                if (string.IsNullOrEmpty(resolution) || string.IsNullOrWhiteSpace(resolution))
                    throw new ArgumentNullException("resolution");

                if (size <= 0)
                    throw new ArgumentException($"Display size cannot be less or equal to 0. Entered value: {size}");

                AspectRatio = aspectRatio;
                MaxRefreshRate = maxRefreshRate;
                Resolution = resolution;
                Size = size;
            }
            catch (ArgumentNullException exception)
            {
                throw exception;
            }
            catch (ArgumentException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public string AspectRatio { get; }
        public int MaxRefreshRate { get; }
        public string Resolution { get; }
        public double Size { get; }
    }
}