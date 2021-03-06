﻿using GeekStore.Domain.Model.Peripherals;

namespace GeekStore.Factory
{
    public static class HeadphonesFactory
    {
        public static Headphones CreateHeadphones()
        {
            return new Headphones(16, "Philips", 126, "A5 PROi", Headphones.HeadphonesType.OverEar);
        }

        public static Headphones CreateHeadphones(int impendance, string manufacturer, int maxVolume, string model, Headphones.HeadphonesType headphonesType)
        {
            return new Headphones(impendance, manufacturer, maxVolume, model, headphonesType);
        }
    }
}
