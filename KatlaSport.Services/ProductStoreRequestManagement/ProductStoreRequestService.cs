using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using KatlaSport.DataAccess;
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
        /// <param name="userContext">User context.</param>
        public ProductStoreRequestService(IProductStoreRequestContext productStoreContext, IUserContext userContext)
        {
            _context = productStoreContext ?? throw new ArgumentNullException(nameof(productStoreContext));
            _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
        }

        /// <inheritdoc/>
        public async Task<FeedbackRequest> CreateRequest(UpdateRequest updateRequest)
        {
            var request = Mapper.Map<Request>(updateRequest);
            request.Time = DateTime.Now;
            request.UserId = _userContext.UserId;
            _context.Requests.Add(request);

            await _context.SaveChangesAsync();

            return Mapper.Map<FeedbackRequest>(request);
        }

        /// <inheritdoc/>
        public async Task<List<FeedbackRequest>> GetRequests()
        {
            var dbRequests = await _context.Requests.ToArrayAsync();
            var requests = dbRequests.Select(r => Mapper.Map<FeedbackRequest>(r)).ToList();

            return requests;
        }

        /// <inheritdoc/>
        public async Task<FeedbackRequest> SetStatusAsync(int requestId, bool status)
        {
            var dbRequests = _context.Requests.Where(r => r.Id == requestId).FirstOrDefault();

            if (dbRequests.IsCancelled != status)
            {
                dbRequests.IsCancelled = status;
                await _context.SaveChangesAsync();
            }

            return Mapper.Map<FeedbackRequest>(dbRequests);
        }
    }
}
