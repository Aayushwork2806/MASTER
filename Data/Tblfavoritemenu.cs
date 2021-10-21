using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("tblfavoritemenu")]
    [Index(nameof(LngUnitId), Name = "FK_tblFavoriteMenu_BusinessUnits")]
    [Index(nameof(LngMenuId), Name = "FK_tblFavoriteMenu_Menus")]
    [Index(nameof(LngRoleId), Name = "FK_tblFavoriteMenu_Role")]
    [Index(nameof(LngUserId), Name = "FK_tblFavoriteMenu_Users")]
    public partial class Tblfavoritemenu
    {
        [Key]
        public int Id { get; set; }
        [Column("lngUserId")]
        public int LngUserId { get; set; }
        [Column("lngRoleId")]
        public int LngRoleId { get; set; }
        [Column("lngMenuId")]
        public int LngMenuId { get; set; }
        [Column("imgIcon")]
        public byte[] ImgIcon { get; set; }
        [Column("strTooltip")]
        [StringLength(50)]
        public string StrTooltip { get; set; }
        [Column("lngUnitId")]
        public int? LngUnitId { get; set; }
        [Column("bitAddToTile")]
        public bool BitAddToTile { get; set; }

        [ForeignKey(nameof(LngMenuId))]
        [InverseProperty(nameof(Menu.Tblfavoritemenus))]
        public virtual Menu LngMenu { get; set; }
        [ForeignKey(nameof(LngRoleId))]
        [InverseProperty(nameof(Role.Tblfavoritemenus))]
        public virtual Role LngRole { get; set; }
        [ForeignKey(nameof(LngUnitId))]
        [InverseProperty(nameof(Businessunit.Tblfavoritemenus))]
        public virtual Businessunit LngUnit { get; set; }
        [ForeignKey(nameof(LngUserId))]
        [InverseProperty(nameof(User.Tblfavoritemenus))]
        public virtual User LngUser { get; set; }
    }
}
