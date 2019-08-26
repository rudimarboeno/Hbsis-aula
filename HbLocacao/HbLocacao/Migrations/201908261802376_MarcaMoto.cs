namespace HbLocacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MarcaMoto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MarcaMotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marcamotos = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MarcaMotoes");
        }
    }
}
