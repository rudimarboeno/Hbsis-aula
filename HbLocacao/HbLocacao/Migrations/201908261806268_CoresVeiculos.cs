namespace HbLocacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoresVeiculos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoresVeiculos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cores = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CoresVeiculos");
        }
    }
}
