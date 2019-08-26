namespace HbLocacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloAutomovels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ModeloAltomovels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Modelo = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ModeloAltomovels");
        }
    }
}
