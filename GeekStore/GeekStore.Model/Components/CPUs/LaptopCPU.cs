namespace GeekStore.Model.Components.CPUs
{
    public class LaptopCPU : CPU
    {
        public LaptopCPU(double baseFrequency, double boostFrequency, CPUCores cores, CPUManufacturer manufacturer, string model, int tdp, int threads)
                  : base(baseFrequency, boostFrequency, cores, manufacturer, model, tdp, threads) { }
    }
}
