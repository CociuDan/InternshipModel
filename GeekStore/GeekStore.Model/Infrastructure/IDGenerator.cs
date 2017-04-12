namespace GeekStore.Domain.Infrastucture
{
    public class IDGenerator<T> : IIDGenerator<T>
    {
        private static int _id = 1;

        public static int NextID()
        {
            return _id++;
        }

        public int NextID<T>()
        {
            return NextID();
        }
    }
}