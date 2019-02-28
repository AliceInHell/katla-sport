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
        Task<FeedbackRequest> CreateRequestAsync(UpdateRequest updateRequest);

        /// <summary>
        /// Get requests.
        /// </summary>
        /// <returns><see cref="Task{List{FeedbackRequest}}"/>.</returns>
        Task<List<FeedbackRequest>> GetRequestsAsync();

        /// <summary>
        /// Get requests in hive.
        /// </summary>
        /// <param name="hiveId">Hive id.</param>
        /// <returns><see cref="Task{List{FeedbackRequest}}"/>.</returns>
        Task<List<FeedbackRequest>> GetRequestsAsync(int hiveId);

        /// <summary>
        /// Gets requests in section.
        /// </summary>
        /// <param name="hiveId">Hive id.</param>
        /// <param name="sectionId">Hive section id.</param>
        /// <returns><see cref="Task{List{FeedbackRequest}}"/>.</returns>
        Task<List<FeedbackRequest>> GetRequestsAsync(int hiveId, int sectionId);

        /// <summary>
        /// Gets request by id.
        /// </summary>
        /// <param name="hiveId">Hive id.</param>
        /// <param name="sectionId">hive section id.</param>
        /// <param name="requestId">Requqest id.</param>
        /// <returns><see cref="Task{FeedbackRequest}"/>.</returns>
        Task<FeedbackRequest> GetRequestsAsync(int hiveId, int sectionId, int requestId);

        /// <summary>
        /// Approve request.
        /// </summary>
        /// <param name="requestId">Request id.</param>
        /// <returns><see cref="Task"/>.</returns>
        Task ApproveRequestAsync(int requestId);

        /// <summary>
        /// Reject and remove request.
        /// </summary>
        /// <param name="requestId">Request id.</param>
        /// <returns><see cref="Task"/>.</returns>
        Task RejectRequestAsync(int requestId);
    }
}
