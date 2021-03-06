﻿using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Factory
{
    public static class SpeakersFactory
    {
        public static Speakers CreateSpeakers()
        {
            return new Speakers("2.0", "Pioneer", 119, "S-DJ08");
        }

        public static Speakers CreateSpeakers(string configuration, string manufacturer, int maxVolume, string model)
        {
            return new Speakers(configuration, manufacturer, maxVolume, model);
        }
    }
}
