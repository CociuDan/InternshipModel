using System;
using System.Text;

namespace GeekStore.Model.Components
{
    public class GPU : IItem
    {
        public GPU(string architecture, int interfaceWidth, string manufacturer, string memoryInterface, string model, int vram)
        {

            if (string.IsNullOrEmpty(architecture.Trim()))
                throw new ArgumentNullException(architecture);

            if (interfaceWidth <= 0 || interfaceWidth % 2 != 0)
                throw new ArgumentException($"GPU Interface Width cannot be less or equal to 0 or not divided by 2. Entered value: {interfaceWidth}");

            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(nameof(manufacturer));

            if (string.IsNullOrEmpty(memoryInterface.Trim()))
                throw new ArgumentNullException(nameof(memoryInterface));

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            if (vram <= 0 || vram % 2 != 0)
                throw new ArgumentException($"GPU VRAM cannot be less or equal to 0 or not divided by 2. Entered value: {vram}");

            Architecture = architecture;
            InterfaceWidth = interfaceWidth;
            Manufacturer = manufacturer;
            MemoryInterface = memoryInterface;
            Model = model;
            VRAM = vram;
        }


        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tArchitecture: {Architecture}");
                sb.AppendLine($"\tInterface Width: {InterfaceWidth}bit");
                sb.AppendLine($"\tMemory Interface: {MemoryInterface}");
                sb.AppendLine($"\tVRAM: {VRAM}GB");
                return sb.ToString();
            }
        }

        public string Architecture { get; }
        public int InterfaceWidth { get; }
        public string Manufacturer { get; }
        public string MemoryInterface { get; }
        public string Model { get; }
        public int VRAM { get; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Manufacturer, Model, VRAM, MemoryInterface, InterfaceWidth);
        }
    }
}