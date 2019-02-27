using KatlaSport.Services.ProductManagement;
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
    [RoutePrefix("api/store")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [CustomExceptionFilter]
    [SwaggerResponseRemoveDefaults]
    public class ProductStoreController :   ApiController
    {
        private readonly IProductStoreService _productStoreService;

        public ProductStoreController(IProductStoreService productStoreService)
        {
            _productStoreService = productStoreService ?? throw new ArgumentNullException(nameof(productStoreService));
        }

        [HttpGet]
        [Route("{hiveSectionId:int:min(1)}")]
        [SwaggerResponse(HttpStatusCode.OK, Description = "Returns a list section products.", Type = typeof(ProductStoreItem[]))]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public async Task<IHttpActionResult> GetProductStoreItems([FromUri] int hiveSectionId)
        {
            var productStoreItems = await _productStoreService.GetProductStoreItemsAsync(hiveSectionId);
            return Ok(productStoreItems);
        }
    }
}