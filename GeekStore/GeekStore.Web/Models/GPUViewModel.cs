namespace GeekStore.UI.Models
{
    public class GPUViewModel : ProductViewModel
    {
        public string Architecture { get; set; }
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {VRAM} {Architecture} {MemoryInterface} {InterfaceWidth}";
            }
        }
        public int InterfaceWidth { get; set; }
        public string MemoryInterface { get; set; }
        public int VRAM { get; set; }
    }
}