using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace EFLib
{
    public class BloggingContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"balbal");
        }
    }

    public class Location
    {
        [Key]
        public string ID
        { get; set; }

        public bool IsActive { get; set; } = true;

        public string ParentID
        {
            get;
            set;
        }

        public LocationLevel Level

        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }

    public enum LocationLevel
    {
        Province = 1,
        City,
        Area,
        Section
    }
}