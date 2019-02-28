using System;

namespace KatlaSport.Services.ProductStoreManagement
{
    /// <summary>
    /// Represents a request for add some products.
    /// </summary>
    public class FeedbackRequest
    {
        /// <summary>
        /// Gets or sets request id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets product store id.
        /// </summary>
        public int ProductStoreId { get; set; }

        /// <summary>
        /// Gets or sets request time.
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets ...
        /// </summary>
        public bool IsCancelled { get; set; }
    }
}
