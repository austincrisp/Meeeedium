namespace Meeeedium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        TeaserText = c.String(),
                        CreatedDate = c.String(),
                        Body = c.String(),
                        Public = c.Boolean(nullable: false),
                        AuthorId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AuthorId)
                .Index(t => t.AuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "AuthorId", "dbo.AspNetUsers");
            DropIndex("dbo.Blogs", new[] { "AuthorId" });
            DropTable("dbo.Blogs");
        }
    }
}
