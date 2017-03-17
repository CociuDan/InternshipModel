using GeekStore.Model.Components;

namespace GeekStore.Factory
{
    public class MotherboardFactory
    {
        public static Motherboard CreateMotherboard()
        {
            return new Motherboard("Intel Q65 Express", "DELL", "0J3C2F", 2, 4, "LGA1155");
        }

        public static Motherboard CreateMotherboard(string chipset, string manufacturer, string model, int pcieSlots, int ramSlots, string socket)
        {
            return new Motherboard(chipset, manufacturer, model, pcieSlots, ramSlots, socket);
        }
    }
}
