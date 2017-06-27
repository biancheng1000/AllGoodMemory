namespace AllGoodMemory.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydaughter.[mydaughter.dariy]")]
    public partial class mydaughter_dariy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string Writer { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string Content { get; set; }
    }
}
