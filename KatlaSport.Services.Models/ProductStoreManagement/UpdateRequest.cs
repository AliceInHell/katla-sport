namespace KatlaSport.Services.ProductStoreManagement
{
    /// <summary>
    /// Represents a request for creating and updating a request.
    /// </summary>
    public class UpdateRequest
    {
        /// <summary>
        /// Gets or sets product store id.
        /// </summary>
        public int ProductStoreId { get; set; }

        /// <summary>
        /// Gets or sets additional product amount.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets ...
        /// </summary>
        public bool IsCancelled { get; set; }
    }
}
