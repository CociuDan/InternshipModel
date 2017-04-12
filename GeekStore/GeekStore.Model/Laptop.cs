using System.Text;
using GeekStore.Domain.Components.Disks;

using GeekStore.Domain.Components;
using System;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Domain.PCs
{
    public class Laptop : IItem, IComputer
    {
        public Laptop(CPU cpu, Display display, Disk disk, GPU gpu, string manufacturer, string model, Motherboard motherboard, PowerUnit battery, RAM ram)
        {
                if(battery == null) throw new ArgumentNullException(nameof(battery));
                if(cpu == null) throw new ArgumentNullException(nameof(cpu));
                if(display == null) throw new ArgumentNullException(nameof(display));
                if(disk == null) throw new ArgumentNullException(nameof(disk));
                if(gpu == null) throw new ArgumentNullException(nameof(gpu));
                if (string.IsNullOrEmpty(manufacturer.Trim())) throw new ArgumentNullException(nameof(manufacturer));
                if (string.IsNullOrEmpty(model.Trim())) throw new ArgumentNullException(nameof(model));
                if(motherboard == null) throw new ArgumentNullException(nameof(motherboard));
                if(ram == null) throw new ArgumentNullException(nameof(ram));
                
                CPU = cpu;
                Display = display;
                Disk = disk;
                GPU = gpu;
                Manufacturer = manufacturer;
                Model = model;
                Motherboard = motherboard;
                PowerUnit = battery;
                RAM = ram;          
        }        

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: { Model} ");
                sb.AppendLine($"\tCPU: {CPU.ToString()}");
                sb.AppendLine($"\tRAM: {RAM.ToString()}");
                sb.AppendLine($"\tGPU: {GPU.ToString()}");
                sb.AppendLine($"\tDrive: {Disk.ToString()}");
                sb.AppendLine($"\tDisplay: {Display.ToString()}");
                return sb.ToString();
            }
        }

        public int ID { get; private set; }
        public CPU CPU { get; }
        public Display Display { get; }
        public Disk Disk { get; set; }
        public GPU GPU { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public Motherboard Motherboard { get; }
        public PowerUnit PowerUnit { get; }
        public RAM RAM { get; set; }
    }
}