using System;
using System.Text;

namespace GeekStore.Model.Components
{
    public class Motherboard : IItem
    {
        public Motherboard(string chipset, string manufacturer, string model, int pcieSlots, int ramSlots, string socket)
        {
            if (string.IsNullOrEmpty(chipset.Trim()))
                throw new ArgumentNullException(nameof(chipset));

            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(nameof(manufacturer));

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            if (pcieSlots < 0)
                throw new ArgumentException($"Motherboard cannot have less than 0 PCI-E slots. Entered value: {pcieSlots}");

            if (ramSlots < 1)
                throw new ArgumentException($"Motherboard cannot have less than one RAM slot. Entered value: {ramSlots}");

            if (string.IsNullOrEmpty(socket.Trim()))
                throw new ArgumentNullException(nameof(socket));

            Chipset = chipset;
            Manufacturer = manufacturer;
            Model = model;
            PCIESlots = pcieSlots;
            RAMSlots = ramSlots;
            Socket = socket;
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tChipset: {Chipset}");
                sb.AppendLine($"\tSocket: {Socket}");
                sb.AppendLine($"\tPCI-E Slots: {PCIESlots}");
                sb.AppendLine($"\tRAM Slots: {RAMSlots}");
                return sb.ToString();
            }
        }

        public string Chipset { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public int PCIESlots { get; }
        public int RAMSlots { get; }
        public string Socket { get; }
    }
}