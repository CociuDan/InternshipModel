namespace GeekStore.Model.Components.GPUs
{
    public class LaptopGPU : GPU
    {
        public LaptopGPU(int interfaceWidth, string manufacturer, string memoryInterface, string model, int vram)
                  : base(interfaceWidth, manufacturer, memoryInterface, model, vram) { }
    }
}
