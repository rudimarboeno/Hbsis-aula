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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipodeVeiculo_Fk = c.Int(nullable: false),
                        Marcas_FK = c.Int(nullable: false),
                        Modelos_FK = c.Int(nullable: false),
                        DetalhesVeiculos_FK = c.Int(nullable: false),
                        Placa = c.String(),
                        PeriodoLocacao_FK = c.Int(nullable: false),
                        Usuario_FK = c.Int(nullable: false),
                        TermosDeUso_Id = c.Boolean(nullable: false),
                        TermosDeUso_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DetalhesVeiculos", t => t.DetalhesVeiculos_FK, cascadeDelete: true)
                .ForeignKey("dbo.Marcas", t => t.Marcas_FK, cascadeDelete: true)
                .ForeignKey("dbo.Modelos", t => t.Modelos_FK, cascadeDelete: true)
                .ForeignKey("dbo.PeriodoLocacaos", t => t.PeriodoLocacao_FK, cascadeDelete: true)
                .ForeignKey("dbo.TermosDeUsoes", t => t.TermosDeUso_Id1)
                .ForeignKey("dbo.TipodeVeiculoes", t => t.TipodeVeiculo_Fk, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_FK, cascadeDelete: true)
                .Index(t => t.TipodeVeiculo_Fk)
                .Index(t => t.Marcas_FK)
                .Index(t => t.Modelos_FK)
                .Index(t => t.DetalhesVeiculos_FK)
                .Index(t => t.PeriodoLocacao_FK)
                .Index(t => t.Usuario_FK)
                .Index(t => t.TermosDeUso_Id1);
            
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
                "dbo.TipodeVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modelos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Marcas_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.Marcas_Id)
                .Index(t => t.Marcas_Id);
            
            CreateTable(
                "dbo.PeriodoLocacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataInicio = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        ResidoFora = c.Boolean(nullable: false),
                        Carona = c.Boolean(nullable: false),
                        PCD = c.Boolean(nullable: false),
                        TrabalhoNoturno = c.Boolean(nullable: false),
                        UserAdmin = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacaos", "Usuario_FK", "dbo.Usuarios");
            DropForeignKey("dbo.Locacaos", "TipodeVeiculo_Fk", "dbo.TipodeVeiculoes");
            DropForeignKey("dbo.Locacaos", "TermosDeUso_Id1", "dbo.TermosDeUsoes");
            DropForeignKey("dbo.Locacaos", "PeriodoLocacao_FK", "dbo.PeriodoLocacaos");
            DropForeignKey("dbo.Locacaos", "Modelos_FK", "dbo.Modelos");
            DropForeignKey("dbo.Modelos", "Marcas_Id", "dbo.Marcas");
            DropForeignKey("dbo.Locacaos", "Marcas_FK", "dbo.Marcas");
            DropForeignKey("dbo.Marcas", "TipodeVeiculo_Id", "dbo.TipodeVeiculoes");
            DropForeignKey("dbo.Locacaos", "DetalhesVeiculos_FK", "dbo.DetalhesVeiculos");
            DropIndex("dbo.Modelos", new[] { "Marcas_Id" });
            DropIndex("dbo.Marcas", new[] { "TipodeVeiculo_Id" });
            DropIndex("dbo.Locacaos", new[] { "TermosDeUso_Id1" });
            DropIndex("dbo.Locacaos", new[] { "Usuario_FK" });
            DropIndex("dbo.Locacaos", new[] { "PeriodoLocacao_FK" });
            DropIndex("dbo.Locacaos", new[] { "DetalhesVeiculos_FK" });
            DropIndex("dbo.Locacaos", new[] { "Modelos_FK" });
            DropIndex("dbo.Locacaos", new[] { "Marcas_FK" });
            DropIndex("dbo.Locacaos", new[] { "TipodeVeiculo_Fk" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.TermosDeUsoes");
            DropTable("dbo.PeriodoLocacaos");
            DropTable("dbo.Modelos");
            DropTable("dbo.TipodeVeiculoes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Locacaos");
            DropTable("dbo.DetalhesVeiculos");
        }
    }
}
