namespace HbLocacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoDeVeiculos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoDeVeiculoes",
                c => new
                    {
                        Automovel = c.String(nullable: false, maxLength: 128),
                        Moto = c.String(),
                        Bicicleta = c.String(),
                        Patinete = c.String(),
                    })
                .PrimaryKey(t => t.Automovel);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoDeVeiculoes");
        }
    }
}
