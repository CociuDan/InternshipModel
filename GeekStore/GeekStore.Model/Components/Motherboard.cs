using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Domain.Components
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

            if (pcieSlots < 0 && pcieSlots > 6)
                throw new ArgumentException($"Motherboard cannot have less than 0 or more than 6 PCI-E slots. Entered value: {pcieSlots}");

            if (ramSlots < 1 && ramSlots > 8)
                throw new ArgumentException($"Motherboard cannot have less than one or more than 8 RAM slots. Entered value: {ramSlots}");

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

        public int ID { get; private set; }
        public string Chipset { get; private set; }
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public int PCIESlots { get; private set; }
        public int RAMSlots { get; private set; }
        public string Socket { get; private set; }
    }
}