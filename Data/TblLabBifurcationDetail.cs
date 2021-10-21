using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tbl_lab_bifurcation_details")]
    [Index(nameof(SubjectId), Name = "FK_tbl_lab_bifurcation_details_Subject")]
    [Index(nameof(TeacherId), Name = "FK_tbl_lab_bifurcation_details_Teacher")]
    [Index(nameof(BifurcationMasterId), Name = "FK_tbl_lab_bifurcation_details_tbl_lab_bifurcation_master")]
    public partial class TblLabBifurcationDetail
    {
        public TblLabBifurcationDetail()
        {
            TblAllotments = new HashSet<TblAllotment>();
        }

        [Key]
        [Column("bifurcation_details_id")]
        public long BifurcationDetailsId { get; set; }
        [Column("bifurcation_master_id")]
        public long? BifurcationMasterId { get; set; }
        [Column("subject_id")]
        public int? SubjectId { get; set; }
        [Column("teacher_id")]
        public int? TeacherId { get; set; }
        [Column("description")]
        public string Description { get; set; }

        [ForeignKey(nameof(BifurcationMasterId))]
        [InverseProperty(nameof(TblLabBifurcationMaster.TblLabBifurcationDetails))]
        public virtual TblLabBifurcationMaster BifurcationMaster { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("TblLabBifurcationDetails")]
        public virtual Subject Subject { get; set; }
        [InverseProperty(nameof(TblAllotment.BifurcationDetails))]
        public virtual ICollection<TblAllotment> TblAllotments { get; set; }
    }
}
