using ChamCong_NhanDienKhuonMat.Server.Models;
using ChamCongNhanDienKhuonMat.Model;
using Microsoft.EntityFrameworkCore;

namespace ChamCongNhanDienKhuonMat.DB
{
    public class NhanDienDBContext : DbContext
    {
        public NhanDienDBContext(DbContextOptions<NhanDienDBContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FaceData> FaceDatas { get; set; }
        public DbSet<TimeKeeping> TimeKeepings { get; set; }
        public DbSet<TimeEntity> Times { get; set; }
        public DbSet<Unknown> Unknowns { get; set; }

        //fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<FaceData>(entity =>
            {
                entity.ToTable("FaceData");
                entity.HasKey(e => e.Id);
              
                        
            });

            modelBuilder.Entity<TimeKeeping>(entity => {
                entity.ToTable("TimeKeeping");
                entity.HasKey(e => e.Id);
                
            });
        }
    }
}
