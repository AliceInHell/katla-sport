using KatlaSport.Services.ProductStoreManagement;
using KatlaSport.WebApi.CustomFilters;
using Microsoft.Web.Http;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace KatlaSport.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [RoutePrefix("api/productRequests")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [CustomExceptionFilter]
    [SwaggerResponseRemoveDefaults]
    public class ProductStoreRequestController : ApiController
    {
        private readonly IProductStoreRequestService _productStoreRequestService;

        public ProductStoreRequestController(IProductStoreRequestService productStoreRequestService)
        {
            _productStoreRequestService = productStoreRequestService ?? throw new ArgumentNullException(nameof(productStoreRequestService));
        }

        [HttpGet]
        [Route("")]
        [SwaggerResponse(HttpStatusCode.OK, Description = "Returns a list of requests.", Type = typeof(FeedbackRequest[]))]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public async Task<IHttpActionResult> GetRequestsAsync()
        {            
            var products = await _productStoreRequestService.GetRequests();
            return Ok(products);
        }

        [HttpPost]
        [Route("")]
        [SwaggerResponse(HttpStatusCode.Created, Description = "Creates a new request.")]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.Conflict)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public async Task<IHttpActionResult> CreateRequestAsync([FromBody] UpdateRequest createRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await _productStoreRequestService.CreateRequest(createRequest);
            var location = string.Format("/api/productRequests/{0}", product.Id);

            return Created<FeedbackRequest>(location, product);
        }
    }
}