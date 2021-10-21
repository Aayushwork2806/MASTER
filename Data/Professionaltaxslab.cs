using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("professionaltaxslab")]
    [Index(nameof(AssmentYearId), Name = "FK_ProfessionalTaxSlab_FinancialYear")]
    public partial class Professionaltaxslab
    {
        [Key]
        public int Id { get; set; }
        public double RangeFrom { get; set; }
        public double RangeTo { get; set; }
        public double YearlyTax { get; set; }
        public double MonthlyTax { get; set; }
        public int AssmentYearId { get; set; }

        [ForeignKey(nameof(AssmentYearId))]
        [InverseProperty(nameof(Financialyear.Professionaltaxslabs))]
        public virtual Financialyear AssmentYear { get; set; }
    }
}
