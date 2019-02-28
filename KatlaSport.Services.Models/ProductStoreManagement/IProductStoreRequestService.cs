using System.Collections.Generic;
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
        Task<FeedbackRequest> CreateRequest(UpdateRequest updateRequest);

        /// <summary>
        /// Get requests.
        /// </summary>
        /// <returns><see cref="Task{List{FeedbackRequest}}"/>.</returns>
        Task<List<FeedbackRequest>> GetRequests();

        /// <summary>
        /// Set request status.
        /// </summary>
        /// <param name="requestId">Id.</param>
        /// <param name="status">Status.</param>
        /// <returns><see cref="Task{FeedbackRequest}"/>.</returns>
        Task<FeedbackRequest> SetStatusAsync(int requestId, bool status);
    }
}
