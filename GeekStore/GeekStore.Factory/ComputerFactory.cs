using GeekStore.Model.Components;
using GeekStore.Model.Components.CPUs;
using GeekStore.Model.Components.Disks;
using GeekStore.Model.Components.GPUs;
using GeekStore.Model.Components.Motherboards;
using GeekStore.Model.Components.PowerUnits;
using GeekStore.Model.Components.RAMs;
using GeekStore.Model.PCs;

namespace GeekStore.Factory
{
    public class ComputerFactory
    {
        public static Desktop CreateDesktop()
        {
            return new Desktop(CoolerFactory.CreateCooler(), CPUFactory.CreateDesktopCPU(), DiskFactory.CreateDesktopHDD(), GPUFactory.CreateDesktopGPU(),
                               MotherboardFactory.CreateDesktopMotherboard(), PowerUnitFactory.CreatePSU(), RAMFactory.CreateDesktopRAM());
        }

        public static Desktop CreateDesktop(Cooler cooler, DesktopCPU cpu, DesktopHDD disk, DesktopGPU gpu, DesktopMotherboard motherboard, PSU psu, DesktopRAM ram)
        {
            return new Desktop(cooler, cpu, disk, gpu, motherboard, psu, ram);
        }

        public static Laptop CreateLaptop()
        {
            return new Laptop(PowerUnitFactory.CreateBattery(), CPUFactory.CreateLaptopCPU(), DisplayFactory.CreateLaptopDisplay(), DiskFactory.CreateLaptopHDD(),
                              GPUFactory.CreateLaptopGPU(), "ASUS", "UX610", MotherboardFactory.CreateLaptopMotherboard(), 800, RAMFactory.CreateLaptopRAM());
        }

        public static Laptop CreateLaptop(Battery battery, LaptopCPU cpu, LaptopDisplay display, LaptopHDD disk, LaptopGPU gpu, string manufacturer,
                                         string model, LaptopMotherboard motherboard, double price, LaptopRAM ram)
        {
            return new Laptop(battery, cpu, display, disk, gpu, manufacturer, model, motherboard, price, ram);
        }
    }
}
