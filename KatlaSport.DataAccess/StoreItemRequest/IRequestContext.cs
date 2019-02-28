namespace KatlaSport.DataAccess.StoreItemRequest
{
    /// <summary>
    /// Represents a context for users requests.
    /// </summary>
    public interface IRequestContext
    {
        /// <summary>
        /// Gets a set of <see cref="Request"/> entities.
        /// </summary>
        IEntitySet<Request> Requests { get; }
    }
}
