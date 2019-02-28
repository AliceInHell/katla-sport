namespace KatlaSport.DataAccess.StoreItemRequest
{
    /// <summary>
    /// Represents a context for users requests.
    /// </summary>
    public interface IProductStoreRequestContext : IAsyncEntityStorage
    {
        /// <summary>
        /// Gets a set of <see cref="Request"/> entities.
        /// </summary>
        IEntitySet<Request> Requests { get; }
    }
}
