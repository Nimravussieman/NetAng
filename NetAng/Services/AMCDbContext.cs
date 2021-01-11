//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;


//namespace NetAng.Models
//{
//    public partial class AMCDbContext : DbContext
//    {
//        public AMCDbContext()
//        {
//        }

//        public AMCDbContext(DbContextOptions<AMCDbContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Student> Students { get; set; }

////        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
////        {
////            if (!optionsBuilder.IsConfigured)
////            {
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
////                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=test", x => x.ServerVersion("10.4.14-mariadb"));
////            }
////        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Student>(entity =>
//            {
//                //entity.HasNoKey();

//                entity.ToTable("student");

//                entity.Property(e => e.BirthDate).HasColumnType("date");

//                entity.Property(e => e.FirstName)
//                    .IsRequired()
//                    .HasColumnType("varchar(50)")
//                    .HasCharSet("utf8mb4")
//                    .HasCollation("utf8mb4_unicode_ci");

//                entity.Property(e => e.Id).HasColumnType("int(11)");

//                entity.Property(e => e.LastName)
//                    .IsRequired()
//                    .HasColumnType("varchar(30)")
//                    .HasCharSet("utf8mb4")
//                    .HasCollation("utf8mb4_unicode_ci");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
