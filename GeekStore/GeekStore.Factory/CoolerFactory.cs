using GeekStore.Model.Components;

namespace GeekStore.Factory
{
    public static class CoolerFactory
    {
        public static Cooler CreateCooler()
        {
            return new Cooler("Deepcool", "Gammaxx 200", "LGA1150, LGA1155, LGA1156, AM2, AM2+, AM3, AM3+", 100); ;
        }

        public static Cooler CreateCooler(string manufacturer, string model, string socket, int maxTdp)
        {
            return new Cooler(manufacturer, model, socket, maxTdp);
        }
    }
}
