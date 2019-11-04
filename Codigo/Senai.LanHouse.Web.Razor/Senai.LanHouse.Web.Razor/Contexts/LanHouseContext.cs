using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Senai.LanHouse.Web.Razor.Domains
{
    public partial class LanHouseContext : DbContext
    {
        public LanHouseContext()
        {
        }

        public LanHouseContext(DbContextOptions<LanHouseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Defeito> Defeito { get; set; }
        public virtual DbSet<RegistroDefeito> RegistroDefeito { get; set; }
        public virtual DbSet<TipoEquipamento> TipoEquipamento { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

                optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress; Initial Catalog=LANHOUSE_ROCKETZ; user id=sa; pwd=info132");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Defeito>(entity =>
            {
                entity.ToTable("DEFEITO");

                entity.HasIndex(e => e.Nome)
                    .HasName("UQ__DEFEITO__E2AB1FF42E190468")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegistroDefeito>(entity =>
            {
                entity.ToTable("REGISTRO_DEFEITO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataDefeito)
                    .HasColumnName("DATA_DEFEITO")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefeitoId).HasColumnName("DEFEITO_ID");

                entity.Property(e => e.Observacao)
                    .IsRequired()
                    .HasColumnName("OBSERVACAO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEquipamentoId).HasColumnName("TIPO_EQUIPAMENTO_ID");

                entity.HasOne(d => d.Defeito)
                    .WithMany(p => p.RegistroDefeito)
                    .HasForeignKey(d => d.DefeitoId)
                    .HasConstraintName("FK__REGISTRO___DEFEI__656C112C");

                entity.HasOne(d => d.TipoEquipamento)
                    .WithMany(p => p.RegistroDefeito)
                    .HasForeignKey(d => d.TipoEquipamentoId)
                    .HasConstraintName("FK__REGISTRO___TIPO___6477ECF3");
            });

            modelBuilder.Entity<TipoEquipamento>(entity =>
            {
                entity.ToTable("TIPO_EQUIPAMENTO");

                entity.HasIndex(e => e.Nome)
                    .HasName("UQ__TIPO_EQU__E2AB1FF456CE7077")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIO");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__USUARIO__161CF724703FE06A")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("SENHA")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });
        }
    }
}
