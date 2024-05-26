using coreapplication.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace coreapplication.Data
{
    public class walkDbContext :DbContext
    {
        public walkDbContext(DbContextOptions dboptions) :base(dboptions)
        { 

        }
        public DbSet<Dificulity> difficulities { get; set; }
        public DbSet<Region> regions { get; set; }
        public DbSet<Walk> walks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var difficulties =new List<Dificulity>()
            {
                new Dificulity()
                {
                    Id =Guid.Parse("007c0611-5674-4f33-b145-41c5d20a2737"),
                    Name= "Easy",
                },
                 new Dificulity()
                {
                    Id =Guid.Parse("599388f1-86ef-4427-acef-03e3be6d6b14"),
                    Name= "difficult",
                },  
            };
            modelBuilder.Entity<Dificulity>().HasData(difficulties);
            var resion = new List<Region>()
            {
                new Region()
                {
                    Id =Guid.Parse("566cbe50-640a-4fe7-8200-d567a16fe723"),
                    Name= "Easy",
                    Code="def",
                    Regionimageurl="image/s.gif"
                },
                 new Region()
                {
                    Id =Guid.Parse("4d3a7665-da45-4466-9033-230b2156f592"),
                    Name= "difficult",
                    Code="ghi",
                    Regionimageurl="images/u.gif"
                },
            };
            modelBuilder.Entity<Region>().HasData(resion);
        }
    }
}
