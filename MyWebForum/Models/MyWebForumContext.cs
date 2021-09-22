using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyWebForum.Models
{
    public partial class MyWebForumContext : DbContext
    {
        public MyWebForumContext()
        {
        }

        public MyWebForumContext(DbContextOptions<MyWebForumContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Userprofile> Userprofiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=LAPTOP-09SC1N0H\\SQLEXPRESS;database=MyWebForum;uid=sa;pwd=123456;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_PRC_CI_AS");

            modelBuilder.Entity<Userprofile>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__USERPROF__AEBB59612EA493DF")
                    .IsClustered(false);

                entity.ToTable("USERPROFILE");

                entity.HasIndex(e => e.UserNo, "UQ__USERPROF__B9B1F225212817B7")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Introduction).HasMaxLength(50);

                entity.Property(e => e.RegTime).HasColumnType("datetime");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
