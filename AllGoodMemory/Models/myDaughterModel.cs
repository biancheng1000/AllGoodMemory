namespace AllGoodMemory.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class myDaughterModel : DbContext
    {
        public myDaughterModel()
            : base("name=myDaughter")
        {
        }

        public virtual DbSet<mydaughter_dariy> mydaughter_dariy { get; set; }
        public virtual DbSet<mydaughter_photogroup> mydaughter_photogroup { get; set; }
        public virtual DbSet<mydaughter_photos> mydaughter_photos { get; set; }
        public virtual DbSet<mydaughter_video> mydaughter_video { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<mydaughter_dariy>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<mydaughter_dariy>()
                .Property(e => e.Writer)
                .IsUnicode(false);

            modelBuilder.Entity<mydaughter_dariy>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<mydaughter_photogroup>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<mydaughter_photogroup>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<mydaughter_photos>()
                .Property(e => e.PotoName)
                .IsUnicode(false);

            modelBuilder.Entity<mydaughter_video>()
                .Property(e => e.VideoName)
                .IsUnicode(false);

            modelBuilder.Entity<mydaughter_video>()
                .Property(e => e.VideoPath)
                .IsUnicode(false);
        }
    }
}
