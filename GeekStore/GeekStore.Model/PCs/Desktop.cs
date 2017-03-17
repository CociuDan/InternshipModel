using System;
using GeekStore.Model.Components;
using GeekStore.Model.Components.Disks;
using GeekStore.Model.Peripherals;

namespace GeekStore.Model.PCs
{
    public class Desktop : IComputer
    {
        public Desktop(Cooler cooler, CPU cpu, Disk drive, GPU gpu, Motherboard motherboard, PowerUnit psu, RAM ram)
        {
            try
            {
                if (cooler == null) throw new ArgumentNullException("cooler");
                if (cpu == null) throw new ArgumentNullException("cpu");
                if (drive == null) throw new ArgumentNullException("drive");
                if (gpu == null) throw new ArgumentNullException("gpu");
                if (motherboard == null) throw new ArgumentNullException("motherboard");
                if (psu == null) throw new ArgumentNullException("psu");
                if (ram == null) throw new ArgumentNullException("ram");
                Cooler = cooler;
                CPU = cpu;
                Disk = drive;
                GPU = gpu;
                Motherboard = motherboard;
                PowerUnit = psu;
                RAM = ram;
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