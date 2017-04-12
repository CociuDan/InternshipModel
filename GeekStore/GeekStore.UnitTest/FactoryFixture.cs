using System;
using NUnit.Framework;
using GeekStore.Factory;
using GeekStore.Domain.Components;

namespace GeekStore.UnitTests
{
    [TestFixture]
    public class FactoryFixture
    {
        [TestCase(1.0, 2.0, CPUCores.DualCore, CPUManufacturer.Intel, "Core 2 Duo", "LGA775", 65, 2)]
        [TestCase(2.0, 1.0, CPUCores.DualCore, CPUManufacturer.Intel, "Core 2 Duo", "LGA775", 65, 2)]

        public void TestCPUFactory(double baseFrequency, double boostFrequency, CPUCores cores, CPUManufacturer manufacturer, string model, string socket, int tdp, int threads)
        {
            CPU cpu = CPUFactory.CreateCPU(baseFrequency, boostFrequency, cores, manufacturer, model, socket, tdp, threads);
            Assert.IsInstanceOf(typeof(CPU), cpu);
        }
    }
}