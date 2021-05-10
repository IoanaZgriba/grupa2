using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApplication3.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication3.Models
{
    public partial class uvtdemosdbContext : DbContext
    {
        public uvtdemosdbContext()
        {
        }

        public uvtdemosdbContext(DbContextOptions<uvtdemosdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<Camera> Camera { get; set; }
        public virtual DbSet<Camin> Camin { get; set; }
        public virtual DbSet<LoginTable> LoginTable { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Taxa> Taxa { get; set; }
        public virtual DbSet<Tichet> Tichet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:uvt-demos-server2.database.windows.net,1433;Initial Catalog=uvt-demos-db;Persist Security Info=False;User ID=adminUser;Password=Alexandru3973;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.HasKey(e => e.IdAdministrator)
                    .HasName("PK__ADMINIST__03E8E3A12975CE1C");

                entity.ToTable("ADMINISTRATOR");

                entity.Property(e => e.IdAdministrator)
                    .HasColumnName("id_administrator")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCamin).HasColumnName("id_camin");

                entity.Property(e => e.NrTelefon).HasColumnName("nr_telefon");

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasColumnName("nume")
                    .HasMaxLength(50);

                entity.Property(e => e.Prenume)
                    .IsRequired()
                    .HasColumnName("prenume")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdCaminNavigation)
                    .WithMany(p => p.Administrator)
                    .HasForeignKey(d => d.IdCamin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ADMINISTR__id_ca__6477ECF3");
            });

            modelBuilder.Entity<Camera>(entity =>
            {
                entity.HasKey(e => e.IdCamera)
                    .HasName("PK__CAMERA__CA0FE41DA5DF9446");

                entity.ToTable("CAMERA");

                entity.Property(e => e.IdCamera)
                    .HasColumnName("id_camera")
                    .ValueGeneratedNever();

                entity.Property(e => e.Etaj).HasColumnName("etaj");

                entity.Property(e => e.IdCamin).HasColumnName("id_camin");

                entity.Property(e => e.NrMobilier).HasColumnName("nr_mobilier");

                entity.Property(e => e.NrPaturi).HasColumnName("nr_paturi");

                entity.HasOne(d => d.IdCaminNavigation)
                    .WithMany(p => p.Camera)
                    .HasForeignKey(d => d.IdCamin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAMERA__id_camin__619B8048");
            });

            modelBuilder.Entity<Camin>(entity =>
            {
                entity.HasKey(e => e.IdCamin)
                    .HasName("PK__CAMIN__C1F3C2E86CCAFCC6");

                entity.ToTable("CAMIN");

                entity.Property(e => e.IdCamin)
                    .HasColumnName("id_camin")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasColumnName("adresa")
                    .HasMaxLength(255);

                entity.Property(e => e.BaieComuna).HasColumnName("baie_comuna");

                entity.Property(e => e.BucatarieComuna).HasColumnName("bucatarie_comuna");

                entity.Property(e => e.IdTaxa).HasColumnName("id_taxa");

                entity.Property(e => e.NrCamere).HasColumnName("nr_camere");

                entity.Property(e => e.Poza)
                    .HasColumnName("poza")
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdTaxaNavigation)
                    .WithMany(p => p.Camin)
                    .HasForeignKey(d => d.IdTaxa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAMIN__id_taxa__5EBF139D");
            });

            modelBuilder.Entity<LoginTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGIN_TABLE");

                entity.Property(e => e.IdAdministrator).HasColumnName("id_administrator");

                entity.Property(e => e.IdStudent).HasColumnName("id_student");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdAdministratorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdAdministrator)
                    .HasConstraintName("FK__LOGIN_TAB__id_ad__04E4BC85");

                entity.HasOne(d => d.IdStudentNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdStudent)
                    .HasConstraintName("FK__LOGIN_TAB__id_st__05D8E0BE");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Cnp)
                    .HasName("PK__STUDENT__D8361756B9EB50D9");

                entity.ToTable("STUDENT");

                entity.Property(e => e.Cnp)
                    .HasColumnName("cnp")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnStudiu).HasColumnName("an_studiu");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Facultate)
                    .IsRequired()
                    .HasColumnName("facultate")
                    .HasMaxLength(70);

                entity.Property(e => e.IdCamera).HasColumnName("id_camera");

                entity.Property(e => e.LuniRestante).HasColumnName("luni_restante");

                entity.Property(e => e.Medie)
                    .HasColumnName("medie")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NrTelefon).HasColumnName("nr_telefon");

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasColumnName("nume")
                    .HasMaxLength(50);

                entity.Property(e => e.Prenume)
                    .IsRequired()
                    .HasColumnName("prenume")
                    .HasMaxLength(50);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnName("sex")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Statut)
                    .HasColumnName("statut")
                    .HasMaxLength(255);

                entity.Property(e => e.Varsta).HasColumnName("varsta");

                entity.HasOne(d => d.IdCameraNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.IdCamera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STUDENT__id_came__6754599E");
            });

            modelBuilder.Entity<Taxa>(entity =>
            {
                entity.HasKey(e => e.IdTaxa)
                    .HasName("PK__TAXA__C1D310DCD7781EBD");

                entity.ToTable("TAXA");

                entity.Property(e => e.IdTaxa)
                    .HasColumnName("id_taxa")
                    .ValueGeneratedNever();

                entity.Property(e => e.DescriereTaxa)
                    .HasColumnName("descriere_taxa")
                    .HasMaxLength(255);

                entity.Property(e => e.Pret)
                    .HasColumnName("pret")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Tichet>(entity =>
            {
                entity.HasKey(e => e.IdTichet)
                    .HasName("PK__TICHET__4E9E5044AD1B8105");

                entity.ToTable("TICHET");

                entity.Property(e => e.IdTichet)
                    .HasColumnName("id_tichet")
                    .ValueGeneratedNever();

                entity.Property(e => e.CnpStudent).HasColumnName("cnp_student");

                entity.Property(e => e.DescriereTichet)
                    .HasColumnName("descriere_tichet")
                    .HasMaxLength(255);

                entity.Property(e => e.IdAdministrator).HasColumnName("id_administrator");

                entity.Property(e => e.Urgenta).HasColumnName("urgenta");

                entity.HasOne(d => d.CnpStudentNavigation)
                    .WithMany(p => p.Tichet)
                    .HasForeignKey(d => d.CnpStudent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICHET__cnp_stud__6FE99F9F");

                entity.HasOne(d => d.IdAdministratorNavigation)
                    .WithMany(p => p.Tichet)
                    .HasForeignKey(d => d.IdAdministrator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TICHET__id_admin__70DDC3D8");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<WebApplication3.Models.StudentList> StudentList { get; set; }
    }
}
