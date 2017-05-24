namespace GeekStore.Infrastucture.Extensions
{
    public class PagedRequestDescription
    {
        public int JtStartIndex { get; set; }
        public int JtPageSize { get; set; }
        public string JtSorting { get; set; }
        public string JtSortingColumn
        {
            get
            {
                var param = JtSorting.Split(' ');
                return param[0];
            }
        }
        public bool JtAscending
        {
            get
            {
                var param = JtSorting.Split(' ');
                bool result = (param[1] == "DESC") ? false : true;
                return result;
            }
        }
    }
}