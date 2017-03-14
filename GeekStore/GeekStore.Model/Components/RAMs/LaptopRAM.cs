using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Model.Components.RAMs
{
    public class LaptopRAM : RAM
    {
        public LaptopRAM(int capacity, int frequency, RAMGeneration ramGeneration) : base(capacity, frequency, ramGeneration) { }
    }
}
