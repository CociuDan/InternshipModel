using System;
using GeekStore.Model.Components;
using GeekStore.Model.Components.Disks;
using GeekStore.Model.Peripherals;

namespace GeekStore.Model.PCs
{
    public class Desktop : IComputer
    {
        public Desktop() { }
        public Desktop(Cooler cooler, CPU cpu, Disk drive, GPU gpu, Motherboard motherboard, PowerUnit psu, RAM ram)
        {
            if (cooler == null) throw new ArgumentNullException(nameof(cooler));
            if (cpu == null) throw new ArgumentNullException(nameof(cpu));
            if (drive == null) throw new ArgumentNullException(nameof(drive));
            if (gpu == null) throw new ArgumentNullException(nameof(gpu));
            if (motherboard == null) throw new ArgumentNullException(nameof(motherboard));
            if (psu == null) throw new ArgumentNullException(nameof(psu));
            if (ram == null) throw new ArgumentNullException(nameof(ram));
            Cooler = cooler;
            CPU = cpu;
            Disk = drive;
            GPU = gpu;
            Motherboard = motherboard;
            PowerUnit = psu;
            RAM = ram;
        }

        public Case Case { get; set; }
        public Cooler Cooler { get; set; }
        public CPU CPU { get; set; }
        public Monitor Display { get; set; }
        public Disk Disk { get; set; }
        public GPU GPU { get; set; }
        public Headphones Headphones { get; set; }
        public Keyboard Keyboard { get; set; }
        public Motherboard Motherboard { get; set; }
        public Mouse Mouse { get; set; }
        public PowerUnit PowerUnit { get; set; }
        public RAM RAM { get; set; }
        public Speakers Speakers { get; set; }
    }
}