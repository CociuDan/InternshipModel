using System;
using System.Text;
using GeekStore.Domain.Model.Components;
using GeekStore.Domain.PCs;

namespace GeekStore.Domain.Model
{
    public class Laptop : Product, IComputer
    {
        public Laptop() { }
        public Laptop(CPU cpu, Display display, Disk disk, GPU gpu, string manufacturer, string model, Motherboard motherboard, PowerUnit battery, RAM ram)
        {
            if (battery == null) throw new ArgumentNullException(nameof(battery));
            if (cpu == null) throw new ArgumentNullException(nameof(cpu));
            if (display == null) throw new ArgumentNullException(nameof(display));
            if (disk == null) throw new ArgumentNullException(nameof(disk));
            if (gpu == null) throw new ArgumentNullException(nameof(gpu));
            if (string.IsNullOrEmpty(manufacturer.Trim())) throw new ArgumentNullException(nameof(manufacturer));
            if (string.IsNullOrEmpty(model.Trim())) throw new ArgumentNullException(nameof(model));
            if (motherboard == null) throw new ArgumentNullException(nameof(motherboard));
            if (ram == null) throw new ArgumentNullException(nameof(ram));

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

        public virtual string Description
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
            protected set
            {
                Description = value;
            }
        }

        public virtual CPU CPU { get; protected set; }
        public virtual Display Display { get; protected set; }
        public virtual Disk Disk { get; protected set; }
        public virtual GPU GPU { get; protected set; }
        public virtual Motherboard Motherboard { get; protected set; }
        public virtual PowerUnit PowerUnit { get; protected set; }
        public virtual RAM RAM { get; protected set; }
    }
}