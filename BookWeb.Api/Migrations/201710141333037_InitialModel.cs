namespace BookWeb.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        ISBN = c.String(),
                        Title = c.String(),
                        Author = c.String(),
                        Release = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.BookID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
