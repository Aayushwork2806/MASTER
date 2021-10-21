using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tbl_allotment")]
    [Index(nameof(UnitId), Name = "FK_tbl_allotment_BusinessUnits")]
    [Index(nameof(DivisionId), Name = "FK_tbl_allotment_Section")]
    [Index(nameof(SessionId), Name = "FK_tbl_allotment_Session")]
    [Index(nameof(SubjectId), Name = "FK_tbl_allotment_Subject")]
    [Index(nameof(TeacherId), Name = "FK_tbl_allotment_Teacher")]
    [Index(nameof(CombinedDetailId), Name = "FK_tbl_allotment_tbl_combined_teacher_class_details")]
    [Index(nameof(BifurcationDetailsId), Name = "FK_tbl_allotment_tbl_lab_bifurcation_details")]
    public partial class TblAllotment
    {
        public TblAllotment()
        {
            TblTimetables = new HashSet<TblTimetable>();
        }

        [Key]
        [Column("allotment_id")]
        public long AllotmentId { get; set; }
        [Column("division_id")]
        public int? DivisionId { get; set; }
        [Column("subject_id")]
        public int? SubjectId { get; set; }
        [Column("teacher_id")]
        public int? TeacherId { get; set; }
        [Column("no_of_periods")]
        public int NoOfPeriods { get; set; }
        [Column("remaining_periods")]
        public int RemainingPeriods { get; set; }
        [Column("charge")]
        public bool? Charge { get; set; }
        [Column("combined_detail_id")]
        public long? CombinedDetailId { get; set; }
        [Column("bifurcation_details_id")]
        public long? BifurcationDetailsId { get; set; }
        [Column("continous_periods")]
        public int? ContinousPeriods { get; set; }
        [Column("description")]
        public string Description { get; set; }
        public int? SessionId { get; set; }
        public int? UnitId { get; set; }
        public bool? Deleted { get; set; }
        public int Sequence { get; set; }

        [ForeignKey(nameof(BifurcationDetailsId))]
        [InverseProperty(nameof(TblLabBifurcationDetail.TblAllotments))]
        public virtual TblLabBifurcationDetail BifurcationDetails { get; set; }
        [ForeignKey(nameof(CombinedDetailId))]
        [InverseProperty(nameof(TblCombinedTeacherClassDetail.TblAllotments))]
        public virtual TblCombinedTeacherClassDetail CombinedDetail { get; set; }
        [ForeignKey(nameof(DivisionId))]
        [InverseProperty(nameof(Section.TblAllotments))]
        public virtual Section Division { get; set; }
        [ForeignKey(nameof(SessionId))]
        [InverseProperty("TblAllotments")]
        public virtual Session Session { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("TblAllotments")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(Businessunit.TblAllotments))]
        public virtual Businessunit Unit { get; set; }
        [InverseProperty(nameof(TblTimetable.Allotment))]
        public virtual ICollection<TblTimetable> TblTimetables { get; set; }
    }
}
