using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using KatlaSport.DataAccess;
using KatlaSport.DataAccess.ProductStore;
using KatlaSport.DataAccess.StoreItemRequest;
using KatlaSport.Services.ProductStoreManagement;

namespace KatlaSport.Services.ProductStoreRequestManagement
{
    /// <summary>
    /// Represent a product store request service.
    /// </summary>
    public class ProductStoreRequestService : IProductStoreRequestService
    {
        private readonly IProductStoreRequestContext _productStoreRequestContext;

        private readonly IProductStoreContext _productStoreContext;

        private readonly IUserContext _userContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductStoreRequestService"/> class.
        /// </summary>
        /// <param name="productStoreRequestContext">Request context.</param>
        /// <param name="productStoreContext">Store context.</param>
        /// <param name="userContext">User context.</param>
        public ProductStoreRequestService(IProductStoreRequestContext productStoreRequestContext, IProductStoreContext productStoreContext, IUserContext userContext)
        {
            _productStoreRequestContext = productStoreRequestContext ?? throw new ArgumentNullException(nameof(productStoreRequestContext));
            _productStoreContext = productStoreContext ?? throw new ArgumentNullException(nameof(productStoreContext));
            _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
        }

        /// <inheritdoc/>
        public async Task ApproveRequestAsync(int requestId)
        {
            var dbRequest = _productStoreRequestContext.Requests.Where(r => r.Id == requestId).FirstOrDefault();

            if (dbRequest == null)
            {
                throw new RequestedResourceNotFoundException();
            }

            var dbStoreItem = _productStoreContext.Items.Where(i => i.Id == dbRequest.ProductStoreId).FirstOrDefault();

            if (dbStoreItem == null)
            {
                throw new RequestedResourceNotFoundException();
            }

            dbStoreItem.Quantity += dbRequest.Quantity;
            dbRequest.IsProcessed = true;

            await _productStoreRequestContext.SaveChangesAsync();
            await _productStoreContext.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task<FeedbackRequest> CreateRequestAsync(UpdateRequest updateRequest)
        {
            var request = Mapper.Map<Request>(updateRequest);
            request.Time = DateTime.Now;
            request.UserId = _userContext.UserId;
            _productStoreRequestContext.Requests.Add(request);

            await _productStoreRequestContext.SaveChangesAsync();

            var createdRequest = Mapper.Map<FeedbackRequest>(request);
            var storeItem = _productStoreContext.Items.Where(i => i.Id == createdRequest.ProductStoreId)
                .FirstOrDefault();

            createdRequest.HiveId = storeItem.HiveSection.StoreHiveId;
            createdRequest.HiveSectionId = storeItem.HiveSectionId;

            return createdRequest;
        }

        /// <inheritdoc/>
        public async Task<List<FeedbackRequest>> GetRequestsAsync()
        {
            var dbRequests = await _productStoreRequestContext.Requests.Where(r => !r.IsProcessed).ToArrayAsync();
            var requests = dbRequests.Select(r =>
            {
                var createdRequest = Mapper.Map<FeedbackRequest>(r);
                var storeItem = _productStoreContext.Items.Where(i => i.Id == createdRequest.ProductStoreId)
                    .FirstOrDefault();

                createdRequest.HiveId = storeItem.HiveSection.StoreHiveId;
                createdRequest.HiveSectionId = storeItem.HiveSectionId;

                return createdRequest;
            }).ToList();

            return requests;
        }

        /// <inheritdoc/>
        public Task<List<FeedbackRequest>> GetRequestsAsync(int hiveId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<FeedbackRequest>> GetRequestsAsync(int hiveId, int sectionId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<FeedbackRequest> GetRequestsAsync(int hiveId, int sectionId, int requestId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public async Task RejectRequestAsync(int requestId)
        {
            var dbRequest = _productStoreRequestContext.Requests.Where(r => r.Id == requestId).First();

            if (dbRequest == null)
            {
                throw new RequestedResourceNotFoundException();
            }

            dbRequest.IsProcessed = true;
            await _productStoreContext.SaveChangesAsync();
        }
    }
}
