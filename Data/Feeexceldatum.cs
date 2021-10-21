using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("feeexceldata")]
    [Index(nameof(ScholarId), Name = "FK_FeeExcelData_Scholar")]
    [Index(nameof(SessionId), Name = "FK_FeeExcelData_Session")]
    public partial class Feeexceldatum
    {
        [Key]
        public int Id { get; set; }
        public int? ScholarId { get; set; }
        public int? ReceiveAmount { get; set; }
        public int? SessionId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? UploadDate { get; set; }

        [ForeignKey(nameof(ScholarId))]
        [InverseProperty("Feeexceldata")]
        public virtual Scholar Scholar { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("Feeexceldata")]
        public virtual Session Session { get; set; }
    }
}
