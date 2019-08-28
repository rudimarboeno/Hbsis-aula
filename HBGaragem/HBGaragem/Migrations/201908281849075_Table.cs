namespace HBGaragem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetalhesVeiculos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cores = c.String(),
                        Placa = c.String(),
                        TipoDeVeiculo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipodeVeiculoes", t => t.TipoDeVeiculo_Id)
                .Index(t => t.TipoDeVeiculo_Id);
            
            CreateTable(
                "dbo.TipodeVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        ResidoFora = c.Boolean(nullable: false),
                        Carona = c.Boolean(nullable: false),
                        PCD = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        TermosDeUso_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TermosDeUsoes", t => t.TermosDeUso_Id)
                .Index(t => t.TermosDeUso_Id);
            
            CreateTable(
                "dbo.TermosDeUsoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Atual = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoDeVeiculo = c.Int(nullable: false),
                        Usuario = c.Int(nullable: false),
                        TempoLocacao = c.String(),
                        Placa = c.String(),
                        Cor = c.Int(nullable: false),
                        PCD = c.Boolean(nullable: false),
                        Carona = c.Boolean(nullable: false),
                        DetalhesVeiculos_Id = c.Int(),
                        TipoDeVeiculos_Id = c.Int(),
                        Usuarios_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DetalhesVeiculos", t => t.DetalhesVeiculos_Id)
                .ForeignKey("dbo.TipodeVeiculoes", t => t.TipoDeVeiculos_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id)
                .Index(t => t.DetalhesVeiculos_Id)
                .Index(t => t.TipoDeVeiculos_Id)
                .Index(t => t.Usuarios_Id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        TipodeVeiculo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipodeVeiculoes", t => t.TipodeVeiculo_Id)
                .Index(t => t.TipodeVeiculo_Id);
            
            CreateTable(
                "dbo.Modelos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Marcas_Id = c.Int(),
                        TipodeVeiculo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.Marcas_Id)
                .ForeignKey("dbo.TipodeVeiculoes", t => t.TipodeVeiculo_Id)
                .Index(t => t.Marcas_Id)
                .Index(t => t.TipodeVeiculo_Id);
            
            CreateTable(
                "dbo.PeriodoLocacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataInicio = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                        TipodeVeiculo_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipodeVeiculoes", t => t.TipodeVeiculo_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.TipodeVeiculo_Id)
                .Index(t => t.Usuario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PeriodoLocacaos", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.PeriodoLocacaos", "TipodeVeiculo_Id", "dbo.TipodeVeiculoes");
            DropForeignKey("dbo.Modelos", "TipodeVeiculo_Id", "dbo.TipodeVeiculoes");
            DropForeignKey("dbo.Modelos", "Marcas_Id", "dbo.Marcas");
            DropForeignKey("dbo.Marcas", "TipodeVeiculo_Id", "dbo.TipodeVeiculoes");
            DropForeignKey("dbo.Locacaos", "Usuarios_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Locacaos", "TipoDeVeiculos_Id", "dbo.TipodeVeiculoes");
            DropForeignKey("dbo.Locacaos", "DetalhesVeiculos_Id", "dbo.DetalhesVeiculos");
            DropForeignKey("dbo.DetalhesVeiculos", "TipoDeVeiculo_Id", "dbo.TipodeVeiculoes");
            DropForeignKey("dbo.TipodeVeiculoes", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "TermosDeUso_Id", "dbo.TermosDeUsoes");
            DropIndex("dbo.PeriodoLocacaos", new[] { "Usuario_Id" });
            DropIndex("dbo.PeriodoLocacaos", new[] { "TipodeVeiculo_Id" });
            DropIndex("dbo.Modelos", new[] { "TipodeVeiculo_Id" });
            DropIndex("dbo.Modelos", new[] { "Marcas_Id" });
            DropIndex("dbo.Marcas", new[] { "TipodeVeiculo_Id" });
            DropIndex("dbo.Locacaos", new[] { "Usuarios_Id" });
            DropIndex("dbo.Locacaos", new[] { "TipoDeVeiculos_Id" });
            DropIndex("dbo.Locacaos", new[] { "DetalhesVeiculos_Id" });
            DropIndex("dbo.Usuarios", new[] { "TermosDeUso_Id" });
            DropIndex("dbo.TipodeVeiculoes", new[] { "Usuario_Id" });
            DropIndex("dbo.DetalhesVeiculos", new[] { "TipoDeVeiculo_Id" });
            DropTable("dbo.PeriodoLocacaos");
            DropTable("dbo.Modelos");
            DropTable("dbo.Marcas");
            DropTable("dbo.Locacaos");
            DropTable("dbo.TermosDeUsoes");
            DropTable("dbo.Usuarios");
            DropTable("dbo.TipodeVeiculoes");
            DropTable("dbo.DetalhesVeiculos");
        }
    }
}
