using AutoMapper;
using KatlaSport.Services.ProductStoreManagement;
using DataAccessProductStoreRequest = KatlaSport.DataAccess.StoreItemRequest.Request;

namespace KatlaSport.Services.ProductStoreRequestManagement
{
    public class ProductStoreRequestManagementProfile : Profile
    {
        public ProductStoreRequestManagementProfile()
        {
            CreateMap<UpdateRequest, DataAccessProductStoreRequest>();
        }
    }
}
