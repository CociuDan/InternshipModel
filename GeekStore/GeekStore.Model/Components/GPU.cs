using System;
using System.Text;

namespace GeekStore.Domain.Model.Components
{
    public class GPU : Product
    {
        public GPU() { }
        public GPU(string architecture, int interfaceWidth, string manufacturer, string memoryInterface, string model, int vram)
        {
            if (string.IsNullOrEmpty(architecture.Trim())) throw new ArgumentNullException(architecture);
            if (interfaceWidth <= 0 || interfaceWidth % 2 != 0) throw new ArgumentException($"GPU Interface Width cannot be less or equal to 0 or not divided by 2. Entered value: {interfaceWidth}");
            if (string.IsNullOrEmpty(manufacturer.Trim())) throw new ArgumentNullException(nameof(manufacturer));
            if (string.IsNullOrEmpty(memoryInterface.Trim())) throw new ArgumentNullException(nameof(memoryInterface));
            if (string.IsNullOrEmpty(model.Trim())) throw new ArgumentNullException(nameof(model));
            if (vram <= 0 || vram % 2 != 0) throw new ArgumentException($"GPU VRAM cannot be less or equal to 0 or not divided by 2. Entered value: {vram}");

            Architecture = architecture;
            InterfaceWidth = interfaceWidth;
            Manufacturer = manufacturer;
            MemoryInterface = memoryInterface;
            Model = model;
            VRAM = vram;
        }

        public virtual string Architecture { get; protected set; }
        public virtual int InterfaceWidth { get; protected set; }
        public virtual string MemoryInterface { get; protected set; }
        public virtual int VRAM { get; protected set; }

        public override string ToString()
        {
            return $"{Manufacturer} {Model} {VRAM} {MemoryInterface} {InterfaceWidth}";
        }
    }
}