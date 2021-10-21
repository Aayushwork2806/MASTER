using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("userstoremapping")]
    [Index(nameof(StoreId), Name = "FK_UserStoreMapping_Stores")]
    [Index(nameof(UserId), Name = "FK_UserStoreMapping_Users")]
    public partial class Userstoremapping
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int StoreId { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Userstoremappings")]
        public virtual Store Store { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Userstoremappings")]
        public virtual User User { get; set; }
    }
}
