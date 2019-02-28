using System;
using AutoMapper;
using KatlaSport.DataAccess.StoreItemRequest;
using KatlaSport.Services.ProductStoreManagement;

namespace KatlaSport.Services.ProductStoreRequestManagement
{
    /// <summary>
    /// Represent a product store request service.
    /// </summary>
    public class ProductStoreRequestService : IProductStoreRequestService
    {
        private readonly IProductStoreRequestContext _context;

        private readonly IUserContext _userContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductStoreRequestService"/> class.
        /// </summary>
        /// <param name="productStoreContext">Context.</param>
        public ProductStoreRequestService(IProductStoreRequestContext productStoreContext)
        {
            _context = productStoreContext ?? throw new ArgumentNullException(nameof(productStoreContext));
        }

        /// <inheritdoc/>
        public void CreateRequest(UpdateRequest updateRequest)
        {
            var request = Mapper.Map<Request>(updateRequest);
            request.Time = DateTime.Now;
            request.UserId = _userContext.UserId;

            _context.Requests.Add(request);
        }
    }
}
