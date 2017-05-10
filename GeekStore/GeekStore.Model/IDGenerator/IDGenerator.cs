namespace GeekStore.Domain.Model.IDGenerator
{
    public class IDGenerator<T> : IIDGenerator<T>
    {
        private static int _id = 1;

        private static int NextIDGenerator()
        {
            return _id++;
        }

        public int NextID { get { return NextIDGenerator(); } }
    }
}