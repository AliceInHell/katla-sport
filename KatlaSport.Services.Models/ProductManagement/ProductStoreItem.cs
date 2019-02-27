namespace KatlaSport.Services.ProductManagement
{
    /// <summary>
    /// Represents a product store item.
    /// </summary>
    public class ProductStoreItem
    {
        /// <summary>
        /// Gets or sets Product id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets product quantity.
        /// </summary>
        public int Quantity { get; set; }
    }
}