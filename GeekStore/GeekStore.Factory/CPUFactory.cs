using GeekStore.Model.Components.CPUs;

namespace GeekStore.Factory
{
    public class CPUFactory
    {
        public static CPU CreateCPU()
        {
            return new CPU(3.40, 3.80, CPU.CPUCores.QuadCore, CPU.CPUManufacturer.Intel, "i7 2600", "LGA1155", 95, 8);
        }

        public static CPU CreateCPU(double baseFrequency, double boostFrequency, CPU.CPUCores cores, CPU.CPUManufacturer manufacturer, string model, string socket, int tdp, int threads)
        {
            return new CPU(baseFrequency, boostFrequency, cores, manufacturer, model, socket, tdp, threads);
        }
    }
}
