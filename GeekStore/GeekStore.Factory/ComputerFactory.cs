using GeekStore.Domain.Components;
using GeekStore.Domain.Components.Disks;
using GeekStore.Domain.PCs;

namespace GeekStore.Factory
{
    public static class ComputerFactory
    {
        public static Desktop CreateDesktop()
        {
            return new Desktop(CoolerFactory.CreateCooler(), CPUFactory.CreateCPU(), DiskFactory.CreateSSD(), GPUFactory.CreateGPU(),
                               MotherboardFactory.CreateMotherboard(), PowerUnitFactory.CreatePowerUnit(), RAMFactory.CreateRAM());
        }

        public static Desktop CreateDesktop(Cooler cooler, CPU cpu, Disk disk, GPU gpu, Motherboard motherboard, PowerUnit psu, RAM ram)
        {
            return new Desktop(cooler, cpu, disk, gpu, motherboard, psu, ram);
        }

        public static Laptop CreateLaptop()
        {
            return new Laptop( CPUFactory.CreateCPU(), DisplayFactory.CreateDisplay(), DiskFactory.CreateHDD(),
                              GPUFactory.CreateGPU(), "ASUS", "UX610", MotherboardFactory.CreateMotherboard(), PowerUnitFactory.CreatePowerUnit(), RAMFactory.CreateRAM());
        }

        public static Laptop CreateLaptop(CPU cpu, Display display, Disk disk, GPU gpu, string manufacturer,
                                         string model, Motherboard motherboard, PowerUnit powerUnit, RAM ram)
        {
            return new Laptop(cpu, display, disk, gpu, manufacturer, model, motherboard, powerUnit, ram);
        }
    }
}
