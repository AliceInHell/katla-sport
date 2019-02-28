namespace KatlaSport.DataAccess.StoreItemRequest
{
    internal class RequestContext : DomainContextBase<ApplicationDbContext>, IProductStoreRequestContext
    {
        public RequestContext(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public IEntitySet<Request> Requests => GetDbSet<Request>();
    }
}
