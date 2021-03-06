﻿using GeekStore.Domain.Model.Components;

namespace GeekStore.Factory
{
    public static class RAMFactory
    {
        public static RAM CreateRAM()
        {
            return new RAM(4096, 1600, RAM.RAMGeneration.DDR3, "Corsair", "Vengeance");
        }

        public static RAM CreateRAM(int capacity, int frequency, RAM.RAMGeneration ramGeneration, string manufacturer, string model)
        {
            return new RAM(capacity, frequency, ramGeneration, manufacturer, model);
        }
    }
}
