using AutoMapper;
using KatlaSport.Services.ProductManagement;
using DataAccessProductStoreItem = KatlaSport.DataAccess.ProductStore.StoreItem;

namespace KatlaSport.Services.ProductStoreManagement
{
    public class ProductStoreManagementProfile : Profile
    {
        public ProductStoreManagementProfile()
        {
            CreateMap<DataAccessProductStoreItem, ProductStoreItem>();
        }
    }
}
