namespace HBGaragem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetalhesVeiculoes",
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
                        Veiculo_FK = c.Int(nullable: false),
                        PeriodoLocacao_FK = c.Int(nullable: false),
                        Usuario_FK = c.Int(nullable: false),
                        TermosDeUso_Id = c.Boolean(nullable: false),
                        Status = c.Int(nullable: false),
                        TermosDeUso_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PeriodoLocacaos", t => t.PeriodoLocacao_FK, cascadeDelete: true)
                .ForeignKey("dbo.TermosDeUsoes", t => t.TermosDeUso_Id1)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_FK, cascadeDelete: true)
                .ForeignKey("dbo.Veiculoes", t => t.Veiculo_FK, cascadeDelete: true)
                .Index(t => t.Veiculo_FK)
                .Index(t => t.PeriodoLocacao_FK)
                .Index(t => t.Usuario_FK)
                .Index(t => t.TermosDeUso_Id1);
            
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
            
            CreateTable(
                "dbo.Veiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipodeVeiculo_Fk = c.Int(nullable: false),
                        DetalhesVeiculo_FK = c.Int(nullable: false),
                        Marcas_Fk = c.Int(nullable: false),
                        Modelos_FK = c.Int(nullable: false),
                        Placa = c.String(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DetalhesVeiculoes", t => t.DetalhesVeiculo_FK, cascadeDelete: true)
                .ForeignKey("dbo.Marcas", t => t.Marcas_Fk, cascadeDelete: true)
                .ForeignKey("dbo.Modelos", t => t.Modelos_FK, cascadeDelete: true)
                .ForeignKey("dbo.TipodeVeiculoes", t => t.TipodeVeiculo_Fk, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.TipodeVeiculo_Fk)
                .Index(t => t.DetalhesVeiculo_FK)
                .Index(t => t.Marcas_Fk)
                .Index(t => t.Modelos_FK)
                .Index(t => t.Usuario_Id);
            
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
                "dbo.Vagas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vaga = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacaos", "Veiculo_FK", "dbo.Veiculoes");
            DropForeignKey("dbo.Veiculoes", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Veiculoes", "TipodeVeiculo_Fk", "dbo.TipodeVeiculoes");
            DropForeignKey("dbo.Veiculoes", "Modelos_FK", "dbo.Modelos");
            DropForeignKey("dbo.Modelos", "Marcas_Id", "dbo.Marcas");
            DropForeignKey("dbo.Veiculoes", "Marcas_Fk", "dbo.Marcas");
            DropForeignKey("dbo.Marcas", "TipodeVeiculo_Id", "dbo.TipodeVeiculoes");
            DropForeignKey("dbo.Veiculoes", "DetalhesVeiculo_FK", "dbo.DetalhesVeiculoes");
            DropForeignKey("dbo.Locacaos", "Usuario_FK", "dbo.Usuarios");
            DropForeignKey("dbo.Locacaos", "TermosDeUso_Id1", "dbo.TermosDeUsoes");
            DropForeignKey("dbo.Locacaos", "PeriodoLocacao_FK", "dbo.PeriodoLocacaos");
            DropIndex("dbo.Modelos", new[] { "Marcas_Id" });
            DropIndex("dbo.Marcas", new[] { "TipodeVeiculo_Id" });
            DropIndex("dbo.Veiculoes", new[] { "Usuario_Id" });
            DropIndex("dbo.Veiculoes", new[] { "Modelos_FK" });
            DropIndex("dbo.Veiculoes", new[] { "Marcas_Fk" });
            DropIndex("dbo.Veiculoes", new[] { "DetalhesVeiculo_FK" });
            DropIndex("dbo.Veiculoes", new[] { "TipodeVeiculo_Fk" });
            DropIndex("dbo.Locacaos", new[] { "TermosDeUso_Id1" });
            DropIndex("dbo.Locacaos", new[] { "Usuario_FK" });
            DropIndex("dbo.Locacaos", new[] { "PeriodoLocacao_FK" });
            DropIndex("dbo.Locacaos", new[] { "Veiculo_FK" });
            DropTable("dbo.Vagas");
            DropTable("dbo.Modelos");
            DropTable("dbo.TipodeVeiculoes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Veiculoes");
            DropTable("dbo.Usuarios");
            DropTable("dbo.TermosDeUsoes");
            DropTable("dbo.PeriodoLocacaos");
            DropTable("dbo.Locacaos");
            DropTable("dbo.DetalhesVeiculoes");
        }
    }
}
