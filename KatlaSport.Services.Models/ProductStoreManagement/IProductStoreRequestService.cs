using System.Threading.Tasks;

namespace KatlaSport.Services.ProductStoreManagement
{
    /// <summary>
    /// Represent a product store request service
    /// </summary>
    public interface IProductStoreRequestService
    {
        /// <summary>
        /// Create request.
        /// </summary>
        /// <param name="updateRequest">Updating request</param>
        /// <returns><see cref="Task"/>.</returns>
        Task CreateRequest(UpdateRequest updateRequest);
    }
}
