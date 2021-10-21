using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("temptran")]
    public partial class Temptran
    {
        [Key]
        [Column("lngId")]
        public int LngId { get; set; }
        [Column("lngDocumentId")]
        public int? LngDocumentId { get; set; }
        [Column("lngDocType")]
        public int? LngDocType { get; set; }
        [Column("strDocumentNumber")]
        [StringLength(50)]
        public string StrDocumentNumber { get; set; }
        [Column("datDocumentDate")]
        [MaxLength(6)]
        public DateTime? DatDocumentDate { get; set; }
        [Column("lngItemId")]
        public int? LngItemId { get; set; }
        public long? Qty { get; set; }
        [Column("lngLocationBinBufferId")]
        public int? LngLocationBinBufferId { get; set; }
        public int? DeletedBy { get; set; }
        [Column("datDeletedDate")]
        [MaxLength(6)]
        public DateTime? DatDeletedDate { get; set; }
        public bool? Deleted { get; set; }
    }
}
