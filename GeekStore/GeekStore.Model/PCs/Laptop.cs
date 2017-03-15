using System.Text;
using GeekStore.Model.Components.CPUs;
using GeekStore.Model.Components.Disks;
using GeekStore.Model.Components.GPUs;
using GeekStore.Model.Components.Motherboards;
using GeekStore.Model.Components.PowerUnits;
using GeekStore.Model.Components.RAMs;
using GeekStore.Model.Components;
using System;

namespace GeekStore.Model.PCs
{
    public class Laptop : IItem, IComputer
    {
        private readonly CPU _cpu;
        private readonly Display _display;
        private readonly Disk _disk;
        private readonly GPU _gpu;
        private readonly string _manufacturer;
        private readonly string _model;
        private readonly Motherboard _motherboard;
        private readonly PowerUnit _battery;
        private readonly RAM _ram;


        public Laptop(CPU cpu, Display display, Disk disk, GPU gpu, string manufacturer, string model, Motherboard motherboard, PowerUnit battery, RAM ram)
        {
            try
            {
                if(battery == null) throw new ArgumentNullException("battery");
                if(cpu == null) throw new ArgumentNullException("cpu");
                if(display == null) throw new ArgumentNullException("display");
                if(disk == null) throw new ArgumentNullException("disk");
                if(gpu == null) throw new ArgumentNullException("gpu");
                if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrWhiteSpace(manufacturer)) throw new ArgumentNullException("manufacturer");
                if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model)) throw new ArgumentNullException("model");
                if(motherboard == null) throw new ArgumentNullException("motherboard");
                if(ram == null) throw new ArgumentNullException("ram");

                _battery = battery;
                _cpu = cpu;
                _display = display;
                _disk = disk;
                _gpu = gpu;
                _manufacturer = manufacturer;
                _model = model;
                _motherboard = motherboard;
                _ram = ram;
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

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: { Model} ");
                sb.AppendLine($"\tCPU: {CPU.ToString()}");
                sb.AppendLine($"\tRAM: {RAM.Capacity}MB {RAM.Generation} {RAM.Frequency}Mhz");
                sb.AppendLine($"\tGPU: {GPU.ToString()}");
                sb.AppendLine($"\tDrive: {Disk.Capacity} {Disk.GetType()}");
                sb.AppendLine($"\tDisplay: {Display.AspectRatio} {Display.Resolution} @ {Display.MaxRefreshRate}Hz");
                return sb.ToString();
            }
        }

        public CPU CPU { get { return _cpu; } }
        public Display Display { get { return _display; } }
        public Disk Disk { get { return _disk; } }
        public GPU GPU { get { return _gpu; } }
        public string Manufacturer { get { return _manufacturer; } }
        public string Model { get { return _model; } }
        public RAM RAM { get { return _ram; } }
        public Motherboard Motherboard { get { return _motherboard; } }
        public PowerUnit PowerUnit { get { return _battery; } }
    }
}