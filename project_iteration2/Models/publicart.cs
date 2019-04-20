namespace project_iteration2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("publicart")]
    public partial class publicart
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Gallery_Name { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public string Monday { get; set; }

        public string Tuesday { get; set; }

        public string Wednesday { get; set; }

        public string Thursday { get; set; }

        public string Friday { get; set; }

        public string Saturday { get; set; }

        public string Sunday { get; set; }

        [StringLength(50)]
        public string Opening { get; set; }

        [StringLength(50)]
        public string Painting { get; set; }

        [StringLength(50)]
        public string Sculpture { get; set; }

        [StringLength(50)]
        public string Photography { get; set; }

        [StringLength(50)]
        public string Installation { get; set; }

        [StringLength(50)]
        public string Performance { get; set; }

        [StringLength(50)]
        public string Visual { get; set; }

        [StringLength(50)]
        public string Unisex { get; set; }

        [Column("Toilet ")]
        public string Toilet_ { get; set; }

        public string Gallery_Type { get; set; }

        public string Description { get; set; }

        public string Website { get; set; }

        public string Street { get; set; }
    }
}
