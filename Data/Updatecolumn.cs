using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("updatecolumn")]
    public partial class Updatecolumn
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [StringLength(100)]
        public string FieldName { get; set; }
        [StringLength(100)]
        public string DisplayName { get; set; }
        public bool Deleted { get; set; }
    }
}
