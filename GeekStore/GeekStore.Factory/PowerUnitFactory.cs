using GeekStore.Model.Components;

namespace GeekStore.Factory
{
    public class PowerUnitFactory
    {
        public static PowerUnit CreatePowerUnit()
        {
            return new PowerUnit("Corsair", "CX500", 500);
        }

        public static PowerUnit CreatePowerUnit(string manufacturer, string model, int output)
        {
            return new PowerUnit(manufacturer, model, output);
        }
    }
}
