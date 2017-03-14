using GeekStore.Model.Components.RAMs;

namespace GeekStore.Factory
{
    public class RAMFactory
    {
        public static DesktopRAM CreateDesktopRAM()
        {
            return new DesktopRAM(4096, 1600, RAM.RAMGeneration.DDR3, "Corsair", "Vengeance", 17.5);
        }

        public static DesktopRAM CreateDesktopRAM(int capacity, int frequency, RAM.RAMGeneration ramGeneration, string manufacturer, string model, double price)
        {
            return new DesktopRAM(capacity, frequency, ramGeneration, manufacturer, model, price);
        }

        public static LaptopRAM CreateLaptopRAM()
        {
            return new LaptopRAM(8192, 2400, RAM.RAMGeneration.DDR4);
        }

        public static LaptopRAM CreateLaptopRAM(int capacity, int frequency, RAM.RAMGeneration ramGeneration)
        {
            return new LaptopRAM(capacity, frequency, ramGeneration);
        }
    }
}
