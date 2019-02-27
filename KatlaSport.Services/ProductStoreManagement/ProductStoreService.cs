using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using KatlaSport.DataAccess;
using KatlaSport.DataAccess.ProductStore;
using KatlaSport.Services.ProductManagement;

namespace KatlaSport.Services.ProductStoreManagement
{
    public class ProductStoreService : IProductStoreService
    {
        private readonly IProductStoreContext _context;

        private readonly IUserContext _userContext;

        public ProductStoreService(IProductStoreContext context, IUserContext userContext)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
        }

        public async Task<List<ProductStoreItem>> GetProductStoreItemsAsync(int hiveSectionId)
        {
            var dbStoreItems = await _context.Items.Where(i => i.HiveSectionId == hiveSectionId).ToArrayAsync();
            var storeItems = dbStoreItems.Select(i => Mapper.Map<ProductStoreItem>(i)).ToList();

            return storeItems;
        }
    }
}
