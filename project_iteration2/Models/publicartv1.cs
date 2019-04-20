namespace project_iteration2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class publicartv1 : DbContext
    {
        public publicartv1()
            : base("name=publicartv1")
        {
        }

        public virtual DbSet<publicart> publicarts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
