namespace HbLocacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MarcaAutomovels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MarcaAutomovels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marca = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MarcaAutomovels");
        }
    }
}
