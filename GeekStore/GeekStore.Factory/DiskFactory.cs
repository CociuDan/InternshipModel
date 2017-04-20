using GeekStore.Domain.Model.Components;

namespace GeekStore.Factory
{
    public static class DiskFactory
    {       
        public static Disk CreateHDD()
        {
            return new Disk(1000, "HGST", "Deskstar", DiskType.HDD, 7200);
        }

        public static Disk CreateHDD(int capacity, string manufacturer, string model, DiskType diskType, int rpm)
        {
            return new Disk(capacity, manufacturer, model, diskType, rpm);
        }

        public static Disk CreateSSD()
        {
            return new Disk(240, "Crucial", "BX100", DiskType.SSD, 550, 530);
        }

        public static Disk CreateSSD(int capacity, string manufacturer, string model, DiskType disktype, int readspeed, int writespeed)
        {
            return new Disk(capacity, manufacturer, model, disktype, readspeed, writespeed);
        }
    }
}
