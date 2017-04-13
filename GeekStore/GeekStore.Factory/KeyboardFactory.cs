using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Factory
{
    public static class KeyboardFactory
    {
        public static Keyboard CreateKeyboard()
        {
            return new Keyboard(true, "Corsair", "K70 RGB", Keyboard.KeyboardType.Mechanical);
        }

        public static Keyboard CreateKeyboard(bool backlight, string manufacturer, string model, Keyboard.KeyboardType keyboardType)
        {
            return new Keyboard(backlight, manufacturer, model, keyboardType);
        }
    }
}
