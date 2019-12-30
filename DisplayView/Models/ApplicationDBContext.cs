namespace DisplayView.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
            : base("name=ApplicationDBContext")
        {
        }

        public virtual DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
