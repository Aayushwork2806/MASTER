using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tdsslab")]
    [Index(nameof(AssessmentYearId), Name = "FK_TDSSlab_FinancialYear")]
    [Index(nameof(TdscategoryId), Name = "FK_TDSSlab_Masters")]
    public partial class Tdsslab
    {
        [Key]
        public int Id { get; set; }
        public int AssessmentYearId { get; set; }
        [Column("TDSCategoryId")]
        public int TdscategoryId { get; set; }
        public double TaxFreeAmount { get; set; }
        public double StandardDeduction { get; set; }
        public double SlabFrom { get; set; }
        public double SlabTo { get; set; }
        public double TaxPercent { get; set; }
        public double EduCess { get; set; }
        public double OtherCess { get; set; }

        [ForeignKey(nameof(AssessmentYearId))]
        [InverseProperty(nameof(Financialyear.Tdsslabs))]
        public virtual Financialyear AssessmentYear { get; set; }
        [ForeignKey(nameof(TdscategoryId))]
        [InverseProperty(nameof(Master.Tdsslabs))]
        public virtual Master Tdscategory { get; set; }
    }
}
