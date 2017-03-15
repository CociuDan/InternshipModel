using System;
using System.Text;

namespace GeekStore.Model.Components.GPUs
{
    public class GPU : IItem
    {
        private readonly string _architecture;
        private readonly int _interfaceWidth;
        private readonly string _manufacturer;
        private readonly string _memoryInterface;
        private readonly string _model;
        private readonly int _vram;

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

                _architecture = architecture;
                _interfaceWidth = interfaceWidth;
                _manufacturer = manufacturer;
                _memoryInterface = memoryInterface;
                _model = model;
                _vram = vram;
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

        public string Architecture { get { return _architecture; } }
        public int InterfaceWidth { get { return _interfaceWidth; } }
        public string Manufacturer { get { return _manufacturer; } }
        public string MemoryInterface { get { return _memoryInterface; } }
        public string Model { get { return _model; } }
        public int Vram { get { return _vram; } }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Manufacturer, Model, Vram, MemoryInterface, InterfaceWidth);
        }
    }
}