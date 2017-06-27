namespace AllGoodMemory.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydaughter.[mydaughter.video]")]
    public partial class mydaughter_video
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string VideoName { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string VideoPath { get; set; }
    }
}
