namespace Fina.Core.Requests
{
    public abstract class PagedRequest : Requests
    {
        public int PageSize { get; set; } = Configuration.DefaultPageSize;
        public int pageNumber { get; set; } = Configuration.DefaultPageNumber;
    }
}