using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Domain.Components
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

        public int ID { get; private set; }
        public string Architecture { get; private set; }
        public int InterfaceWidth { get; private set; }
        public string Manufacturer { get; private set; }
        public string MemoryInterface { get; private set; }
        public string Model { get; private set; }
        public int VRAM { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Manufacturer, Model, VRAM, MemoryInterface, InterfaceWidth);
        }
    }
}