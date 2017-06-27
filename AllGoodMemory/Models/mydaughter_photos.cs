namespace AllGoodMemory.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydaughter.[mydaughter.photos]")]
    public partial class mydaughter_photos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string PotoName { get; set; }

        public DateTime? PotoData { get; set; }

        public int? GroupID { get; set; }

        public byte[] Content { get; set; }
    }
}
