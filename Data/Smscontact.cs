using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("smscontacts")]
    [Index(nameof(GroupId), Name = "FK_SMSContacts_Masters")]
    public partial class Smscontact
    {
        [Key]
        public int Id { get; set; }
        public int GroupId { get; set; }
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Organisation { get; set; }
        [Required]
        [StringLength(10)]
        public string CellNo { get; set; }

        [ForeignKey(nameof(GroupId))]
        [InverseProperty(nameof(Master.Smscontacts))]
        public virtual Master Group { get; set; }
    }
}
