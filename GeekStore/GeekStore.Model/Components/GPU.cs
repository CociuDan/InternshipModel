using System;
using System.Text;

namespace GeekStore.Model.Components
{
    public class GPU : IItem
    {
        public GPU(string architecture, int interfaceWidth, string manufacturer, string memoryInterface, string model, int vram)
        {
            try
            {
                if (string.IsNullOrEmpty(architecture) || string.IsNullOrWhiteSpace(architecture))
                    throw new ArgumentNullException(architecture);

                if (interfaceWidth <= 0 || interfaceWidth % 2 != 0)
                    throw new ArgumentException("GPU Interface Width cannot be less or equal to 0 or not divided by 2. Entered value: " + interfaceWidth);

                if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrWhiteSpace(manufacturer))
                    throw new ArgumentNullException(manufacturer);

                if (string.IsNullOrEmpty(memoryInterface) || string.IsNullOrWhiteSpace(memoryInterface))
                    throw new ArgumentNullException(memoryInterface);

                if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
                    throw new ArgumentNullException(model);

                if (vram <= 0 || vram % 2 != 0)
                    throw new ArgumentException("GPU VRAM cannot be less or equal to 0 or not divided by 2. Entered value: " + vram);

                Architecture = architecture;
                InterfaceWidth = interfaceWidth;
                Manufacturer = manufacturer;
                MemoryInterface = memoryInterface;
                Model = model;
                Vram = vram;
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
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tArchitecture: {Architecture}");
                sb.AppendLine($"\tInterface Width: {InterfaceWidth}bit");
                sb.AppendLine($"\tMemory Interface: {MemoryInterface}");
                sb.AppendLine($"\tVRAM: {Vram}GB");
                return sb.ToString();
            }
        }

        public string Architecture { get; }
        public int InterfaceWidth { get; }
        public string Manufacturer { get; }
        public string MemoryInterface { get; }
        public string Model { get; }
        public int Vram { get; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Manufacturer, Model, Vram, MemoryInterface, InterfaceWidth);
        }
    }
}