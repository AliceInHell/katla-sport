using System.Data.Entity.Migrations;

namespace KatlaSport.DataAccess.Migrations
{
    public partial class RequestInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.store_item_request",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        product_store_id = c.Int(nullable: false),
                        user_id = c.Int(nullable: false),
                        time = c.DateTime(nullable: false),
                        amount = c.Int(nullable: false),
                        is_cancelled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.store_item_request");
        }
    }
}
