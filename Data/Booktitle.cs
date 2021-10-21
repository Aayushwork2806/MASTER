using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("booktitles")]
    [Index(nameof(PublisherId), Name = "FK_BookTitles_BookPublisher")]
    [Index(nameof(SupplierId), Name = "FK_BookTitles_BookSupplier")]
    [Index(nameof(BookTypeId), Name = "FK_BookTitles_BookType")]
    [Index(nameof(FaunitId), Name = "FK_BookTitles_BusinessUnits")]
    [Index(nameof(CourseId), Name = "FK_BookTitles_Class")]
    [Index(nameof(BookSeriesId), Name = "FK_BookTitles_Masters")]
    [Index(nameof(CategoryId), Name = "FK_BookTitles_Masters1")]
    [Index(nameof(LocationId), Name = "FK_BookTitles_Masters2")]
    [Index(nameof(MediumId), Name = "FK_BookTitles_Masters3")]
    [Index(nameof(SubjectId), Name = "FK_BookTitles_Subject")]
    public partial class Booktitle
    {
        public Booktitle()
        {
            Bookbookings = new HashSet<Bookbooking>();
            Bookdamageddtls = new HashSet<Bookdamageddtl>();
            Booktitleauthors = new HashSet<Booktitleauthor>();
            Booktitledtls = new HashSet<Booktitledtl>();
        }

        [Key]
        public int Id { get; set; }
        public int BookSeriesId { get; set; }
        public int BookCode { get; set; }
        public int AccessionNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PurchaseDate { get; set; }
        [Required]
        [Column("BookTitle")]
        [StringLength(150)]
        public string BookTitle1 { get; set; }
        [StringLength(150)]
        public string SubTitle { get; set; }
        public int? BookTypeId { get; set; }
        public int PublisherId { get; set; }
        public int? SupplierId { get; set; }
        public int? CourseId { get; set; }
        public int? SubjectId { get; set; }
        public int? CategoryId { get; set; }
        [StringLength(15)]
        public string Edition { get; set; }
        public double? Price { get; set; }
        public double? Mrp { get; set; }
        public int Units { get; set; }
        [Column("ISBN")]
        [StringLength(20)]
        public string Isbn { get; set; }
        [StringLength(10)]
        public string SubsciptionType { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SubscibeFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SubscribeUpto { get; set; }
        public int? LocationId { get; set; }
        [StringLength(15)]
        public string PublishYear { get; set; }
        public int? Pages { get; set; }
        [StringLength(40)]
        public string Scheme { get; set; }
        public int? MediumId { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        [Column("FAUnitId")]
        public int FaunitId { get; set; }
        public int? NoOfPages { get; set; }
        [StringLength(50)]
        public string BillNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Billdate { get; set; }
        [StringLength(20)]
        public string Volume { get; set; }
        public byte[] BarCode { get; set; }
        [StringLength(50)]
        public string EditorName { get; set; }
        [StringLength(50)]
        public string CallNumber { get; set; }
        public int? UnitId { get; set; }

        [ForeignKey(nameof(BookSeriesId))]
        [InverseProperty(nameof(Master.BooktitleBookSeries))]
        public virtual Master BookSeries { get; set; }
        [ForeignKey(nameof(BookTypeId))]
        [InverseProperty(nameof(Booktype.Booktitles))]
        public virtual Booktype BookType { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Master.BooktitleCategories))]
        public virtual Master Category { get; set; }
        [ForeignKey(nameof(CourseId))]
        [InverseProperty(nameof(Class.Booktitles))]
        public virtual Class Course { get; set; }
        [ForeignKey(nameof(FaunitId))]
        [InverseProperty(nameof(Businessunit.Booktitles))]
        public virtual Businessunit Faunit { get; set; }
        [ForeignKey(nameof(LocationId))]
        [InverseProperty(nameof(Master.BooktitleLocations))]
        public virtual Master Location { get; set; }
        [ForeignKey(nameof(MediumId))]
        [InverseProperty(nameof(Master.BooktitleMedia))]
        public virtual Master Medium { get; set; }
        [ForeignKey(nameof(PublisherId))]
        [InverseProperty(nameof(Bookpublisher.Booktitles))]
        public virtual Bookpublisher Publisher { get; set; }
        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Booktitles")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(SupplierId))]
        [InverseProperty(nameof(Booksupplier.Booktitles))]
        public virtual Booksupplier Supplier { get; set; }
        [InverseProperty(nameof(Bookbooking.Book))]
        public virtual ICollection<Bookbooking> Bookbookings { get; set; }
        [InverseProperty(nameof(Bookdamageddtl.Book))]
        public virtual ICollection<Bookdamageddtl> Bookdamageddtls { get; set; }
        [InverseProperty(nameof(Booktitleauthor.Book))]
        public virtual ICollection<Booktitleauthor> Booktitleauthors { get; set; }
        [InverseProperty(nameof(Booktitledtl.Book))]
        public virtual ICollection<Booktitledtl> Booktitledtls { get; set; }
    }
}
