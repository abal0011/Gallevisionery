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

        public int? NoOFCF { get; set; }

        public int? NoOfBsn { get; set; }

        public int? NoOfArt { get; set; }

        public int? MonPed { get; set; }

        public int? TuesPed { get; set; }

        public int? WedPed { get; set; }

        public int? ThursPed { get; set; }

        public int? FriPed { get; set; }

        public int? SatPed { get; set; }

        public int? SunPed { get; set; }

        public int? Parking { get; set; }
        public int? MonPed2 { get; set; }

        public int? TuesPed2 { get; set; }

        public int? WedPed2 { get; set; }

        public int? ThursPed2 { get; set; }

        public int? FriPed2 { get; set; }

        public int? SatPed2 { get; set; }

        public int? SunPed2 { get; set; }
        public int? MonPed3 { get; set; }

        public int? TuesPed3 { get; set; }

        public int? WedPed3 { get; set; }

        public int? ThursPed3 { get; set; }

        public int? FriPed3 { get; set; }

        public int? SatPed3 { get; set; }

        public int? SunPed3 { get; set; }


    }
}
