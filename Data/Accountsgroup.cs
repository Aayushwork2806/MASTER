using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("accountsgroup")]
    public partial class Accountsgroup
    {
        public Accountsgroup()
        {
            Accounts = new HashSet<Account>();
        }

        [Key]
        public int Id { get; set; }
        public int GroupCode { get; set; }
        [Column("InnerGCode")]
        public int InnerGcode { get; set; }
        [Required]
        [StringLength(80)]
        public string GroupName { get; set; }
        [StringLength(1)]
        public string KeyGroup { get; set; }
        [Required]
        [StringLength(1)]
        public string Type { get; set; }
        [StringLength(1)]
        public string Parent { get; set; }
        [StringLength(50)]
        public string Fixed { get; set; }
        [Column("GPEffect")]
        [StringLength(50)]
        public string Gpeffect { get; set; }
        public int? ScheduleNo { get; set; }
        public int? PrintSeq { get; set; }
        [StringLength(1)]
        public string Detail { get; set; }
        public int? AbGroup { get; set; }

        [InverseProperty(nameof(Account.Group))]
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
