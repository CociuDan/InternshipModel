using GeekStore.Domain.Model.Components;
using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Factory
{
    public static class DisplayFactory
    {
        public static Display CreateDisplay()
        {
            return new Display("16:9", 60, "1920x1080", 15.6);
        }

        public static Monitor CreateMonitor()
        {
            return new Monitor("16:9", "ASUS", 165, "ROG Swift PG279Q", "2560x1440", 27);
        }

        public static Monitor CreateMonitor(string aspectRatio, string manufacturer, int maxRefreshRate, string model, string resolution, double size)
        {
            return new Monitor(aspectRatio, manufacturer, maxRefreshRate, model, resolution, size);
        }
    }
}
