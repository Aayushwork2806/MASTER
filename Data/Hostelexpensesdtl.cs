using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("hostelexpensesdtl")]
    [Index(nameof(HostelHeadId), Name = "FK_HostelExpensesDtl_HostalExpenseHead")]
    [Index(nameof(HostelExpensesId), Name = "FK_HostelExpensesDtl_HostelExpenses")]
    public partial class Hostelexpensesdtl
    {
        [Key]
        public int Id { get; set; }
        public int HostelExpensesId { get; set; }
        public int HostelHeadId { get; set; }
        public double Amount { get; set; }
        [StringLength(150)]
        public string Narration { get; set; }

        [ForeignKey(nameof(HostelExpensesId))]
        [InverseProperty(nameof(Hostelexpense.Hostelexpensesdtls))]
        public virtual Hostelexpense HostelExpenses { get; set; }
        [ForeignKey(nameof(HostelHeadId))]
        [InverseProperty(nameof(Hostalexpensehead.Hostelexpensesdtls))]
        public virtual Hostalexpensehead HostelHead { get; set; }
    }
}
