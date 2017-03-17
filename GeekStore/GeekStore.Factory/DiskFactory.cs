using GeekStore.Model.Components.Disks;

namespace GeekStore.Factory
{
    public class DiskFactory
    {       
        public static HDD CreateHDD()
        {
            return new HDD(1000, "HGST", "Deskstar", 7200);
        }

        public static HDD CreateHDD(int capacity, string manufacturer, string model, int rpm)
        {
            return new HDD(capacity, manufacturer, model, rpm);
        }

        public static SSD CreateSSD()
        {
            return new SSD(240, "Crucial", "BX100", 550, 530);
        }

        public static SSD CreateSSD(int capacity, string manufacturer, string model, int readspeed, int writespeed)
        {
            return new SSD(capacity, manufacturer, model, readspeed, writespeed);
        }
    }
}
