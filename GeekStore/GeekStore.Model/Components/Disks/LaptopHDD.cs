namespace GeekStore.Model.Components.Disks
{
    public class LaptopHDD : Disk
    {
        private readonly int _rpm;
        public LaptopHDD(int capacity, int readSpeed, int rpm, int writeSpeed) : base(capacity, readSpeed, writeSpeed)
        {
            _rpm = rpm;
        }

        public int RPM { get { return _rpm; } }
    }
}
