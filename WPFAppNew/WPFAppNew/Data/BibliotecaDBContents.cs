namespace WPFAppNew.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BibliotecaDBContents : DbContext
    {
        public BibliotecaDBContents()
            : base("name=BibliotecaDBContents")
        {
        }

        public virtual DbSet<Autores> Autores { get; set; }
        public virtual DbSet<Editoras> Editoras { get; set; }
        public virtual DbSet<Generos> Generos { get; set; }
        public virtual DbSet<Livro> Livro { get; set; }
        public virtual DbSet<Locacao> Locacao { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autores>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Autores>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Editoras>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Editoras>()
                .Property(e => e.Descrição)
                .IsUnicode(false);

            modelBuilder.Entity<Editoras>()
                .HasMany(e => e.Livro)
                .WithRequired(e => e.Editoras)
                .HasForeignKey(e => e.Editora)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Generos>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Generos>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Generos>()
                .HasMany(e => e.Livro)
                .WithRequired(e => e.Generos)
                .HasForeignKey(e => e.Genero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Livro>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Livro>()
                .Property(e => e.Isbn)
                .IsUnicode(false);

            modelBuilder.Entity<Livro>()
                .Property(e => e.Observacoes)
                .IsUnicode(false);

            modelBuilder.Entity<Livro>()
                .HasMany(e => e.Locacao)
                .WithRequired(e => e.Livro1)
                .HasForeignKey(e => e.Livro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Senha)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Livro)
                .WithRequired(e => e.Usuarios)
                .HasForeignKey(e => e.UsuAlt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Livro1)
                .WithRequired(e => e.Usuarios1)
                .HasForeignKey(e => e.UsuInc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Locacao)
                .WithRequired(e => e.Usuarios)
                .HasForeignKey(e => e.UsuAlt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Locacao1)
                .WithRequired(e => e.Usuarios1)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Locacao2)
                .WithRequired(e => e.Usuarios2)
                .HasForeignKey(e => e.UsuInc)
                .WillCascadeOnDelete(false);
        }
    }
}
