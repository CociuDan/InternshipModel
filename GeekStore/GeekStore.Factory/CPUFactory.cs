using GeekStore.Domain.Model.Components;

namespace GeekStore.Factory
{
    public static class CPUFactory
    {
        public static CPU CreateCPU()
        {
            return new CPU(3.40m, 3.80m, CPUCores.QuadCore, CPUManufacturer.Intel, "i7 2600", "LGA1155", 95, 8);
        }

        public static CPU CreateCPU(decimal baseFrequency, decimal boostFrequency, CPUCores cores, CPUManufacturer manufacturer, string model, string socket, int tdp, int threads)
        {
            return new CPU(baseFrequency, boostFrequency, cores, manufacturer, model, socket, tdp, threads);
        }
    }
}