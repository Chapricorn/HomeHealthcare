namespace ExtendedHomeHealthcare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingcity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Users", "CityId");
            AddForeignKey("dbo.Users", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "CityId", "dbo.Cities");
            DropIndex("dbo.Users", new[] { "CityId" });
            DropTable("dbo.Cities");
        }
    }
}
