using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tbl_combined_teacher_class_details")]
    [Index(nameof(DivisionId), Name = "FK_tbl_combined_teacher_class_details_Section")]
    [Index(nameof(SubjectId), Name = "FK_tbl_combined_teacher_class_details_Subject")]
    [Index(nameof(TeacherId), Name = "FK_tbl_combined_teacher_class_details_Teacher")]
    [Index(nameof(CombinedMasterId), Name = "FK_tbl_combined_teacher_class_details_tbl_combined_teacher_cla2")]
    public partial class TblCombinedTeacherClassDetail
    {
        public TblCombinedTeacherClassDetail()
        {
            TblAllotments = new HashSet<TblAllotment>();
        }

        [Key]
        [Column("combined_details_id")]
        public long CombinedDetailsId { get; set; }
        [Column("combined_master_id")]
        public long? CombinedMasterId { get; set; }
        [Column("division_id")]
        public int? DivisionId { get; set; }
        [Column("teacher_id")]
        public int? TeacherId { get; set; }
        [Column("subject_id")]
        public int? SubjectId { get; set; }
        [Column("description")]
        public string Description { get; set; }

        [ForeignKey(nameof(CombinedMasterId))]
        [InverseProperty(nameof(TblCombinedTeacherClassMaster.TblCombinedTeacherClassDetails))]
        public virtual TblCombinedTeacherClassMaster CombinedMaster { get; set; }
        [ForeignKey(nameof(DivisionId))]
        [InverseProperty(nameof(Section.TblCombinedTeacherClassDetails))]
        public virtual Section Division { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("TblCombinedTeacherClassDetails")]
        public virtual Subject Subject { get; set; }
        [InverseProperty(nameof(TblAllotment.CombinedDetail))]
        public virtual ICollection<TblAllotment> TblAllotments { get; set; }
    }
}
