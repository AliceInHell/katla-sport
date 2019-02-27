using System.Collections.Generic;
using System.Threading.Tasks;
using KatlaSport.Services.ProductManagement;

namespace KatlaSport.Services.ProductStoreManagement
{
    public interface IProductStoreService
    {
        /// <summary>
        /// Gets a list of store products.
        /// </summary>
        /// <param name="hiveSectionId">Section id.</param>
        /// <returns>A <see cref="Task{List{ProductStoreItem}}"/>.</returns>
        Task<List<ProductStoreItem>> GetProductStoreItemsAsync(int hiveSectionId);
    }
}
