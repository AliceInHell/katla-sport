using System;

namespace KatlaSport.DataAccess.StoreItemRequest
{
    /// <summary>
    /// Represents a request for add some products.
    /// </summary>
    public class Request
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
        /// Gets or sets request user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets request time.
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets additional product amount.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets ...
        /// </summary>
        public bool IsProcessed { get; set; }
    }
}
