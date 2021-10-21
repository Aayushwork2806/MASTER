using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tbl_lab_bifurcation_master")]
    [Index(nameof(UnitId), Name = "FK_tbl_lab_bifurcation_master_BusinessUnits")]
    [Index(nameof(DivisionId), Name = "FK_tbl_lab_bifurcation_master_Section")]
    [Index(nameof(SessionId), Name = "FK_tbl_lab_bifurcation_master_Session")]
    public partial class TblLabBifurcationMaster
    {
        public TblLabBifurcationMaster()
        {
            TblLabBifurcationDetails = new HashSet<TblLabBifurcationDetail>();
            TblTimetables = new HashSet<TblTimetable>();
        }

        [Key]
        [Column("bifurcation_master_id")]
        public long BifurcationMasterId { get; set; }
        [Column("division_id")]
        public int? DivisionId { get; set; }
        [Column("continous_peroids")]
        public int? ContinousPeroids { get; set; }
        [Column("no_of_periods")]
        public int? NoOfPeriods { get; set; }
        public int? SessionId { get; set; }
        public int? UnitId { get; set; }

        [ForeignKey(nameof(DivisionId))]
        [InverseProperty(nameof(Section.TblLabBifurcationMasters))]
        public virtual Section Division { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("TblLabBifurcationMasters")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.TblLabBifurcationMasters))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(TblLabBifurcationDetail.BifurcationMaster))]
        public virtual ICollection<TblLabBifurcationDetail> TblLabBifurcationDetails { get; set; }
        [InverseProperty(nameof(TblTimetable.BifurcationMaster))]
        public virtual ICollection<TblTimetable> TblTimetables { get; set; }
    }
}
