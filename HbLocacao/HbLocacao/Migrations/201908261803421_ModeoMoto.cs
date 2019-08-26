namespace HbLocacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeoMoto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ModeloMotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Modelomotos = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ModeloMotoes");
        }
    }
}
