namespace ExtendedHomeHealthcare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingstate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Users", "StateId");
            AddForeignKey("dbo.Users", "StateId", "dbo.States", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "StateId", "dbo.States");
            DropIndex("dbo.Users", new[] { "StateId" });
            DropTable("dbo.States");
        }
    }
}
