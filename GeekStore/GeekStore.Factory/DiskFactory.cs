using GeekStore.Model.Components.Disks;

namespace GeekStore.Factory
{
    public class DiskFactory
    {
        public static DesktopHDD CreateDesktopHDD()
        {
            return new DesktopHDD(240, "HGST", "Deskstar", 70.0, 550, 7200, 530);
        }

        public static DesktopHDD CreateDesktopHDD(int capacity, string manufacturer, string model, double price, int readspeed, int rpm, int writespeed)
        {
            return new DesktopHDD(capacity, manufacturer, model, price, readspeed, rpm, writespeed);
        }

        public static LaptopHDD CreateLaptopHDD()
        {
            return new LaptopHDD(1000, 150, 7200, 180);
        }

        public static LaptopHDD CreateLaptopHDD(int capacity, int readSpeed, int rpm, int writeSpeed)
        {
            return new LaptopHDD(capacity, readSpeed, rpm, writeSpeed);
        }

        public static SSD CreateSSD()
        {
            return new SSD(240, "Crucial", "BX100", 70.0, 550, 530);
        }

        public static SSD CreateSSD(int capacity, string manufacturer, string model, double price, int readSpeed, int writeSpeed)
        {
            return new SSD(capacity, manufacturer, model, price, readSpeed, writeSpeed);
        }
    }
}
