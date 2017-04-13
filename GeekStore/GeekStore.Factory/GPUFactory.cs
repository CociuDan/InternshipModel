using GeekStore.Domain.Model.Components;

namespace GeekStore.Factory
{
    public static class GPUFactory
    {
        public static GPU CreateGPU()
        {
            return new GPU("Maxwell", 128, "MSI", "GDDR5", "750Ti OC", 2);
        }

        public static GPU CreateGPU(string architecture, int interfaceWidth, string manufacturer, string memoryInterface, string model, int vram)
        {
            return new GPU(architecture, interfaceWidth, manufacturer, memoryInterface, model, vram);
        }
    }
}
