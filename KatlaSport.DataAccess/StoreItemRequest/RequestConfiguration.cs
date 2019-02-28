using System.Data.Entity.ModelConfiguration;

namespace KatlaSport.DataAccess.StoreItemRequest
{
    public class RequestConfiguration : EntityTypeConfiguration<Request>
    {
        public RequestConfiguration()
        {
            ToTable("store_item_request");
            HasKey(i => i.Id);
            Property(i => i.UserId).HasColumnName("user_id");
            Property(i => i.ProductStoreId).HasColumnName("product_store_id");
            Property(i => i.Time).HasColumnName("time");
            Property(i => i.Quantity).HasColumnName("amount");
            Property(i => i.IsCancelled).HasColumnName("is_cancelled");
        }
    }
}
