namespace ExtendedHomeHealthcare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingzipcode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ZipCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Zip = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Users", "ZipCodeId");
            AddForeignKey("dbo.Users", "ZipCodeId", "dbo.ZipCodes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "ZipCodeId", "dbo.ZipCodes");
            DropIndex("dbo.Users", new[] { "ZipCodeId" });
            DropTable("dbo.ZipCodes");
        }
    }
}
