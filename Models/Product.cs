using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    [Table("tb_Product")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(250)]
        public string ProductName { get; set; }

        [StringLength(250)]
        public string SeoTitle { get; set; }

        public bool Statuss { get; set; } = true;

        [StringLength(250)]
        public string Images { get; set; }

        // XML trong SQL → map thành string
        public string ListImages { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal Price { get; set; } = 0;

        [Column(TypeName = "decimal(18,0)")]
        public decimal PromotionPrice { get; set; } = 0;

        public bool VAT { get; set; }

        public int Quantity { get; set; } = 0;

        public bool Hot { get; set; }

        [StringLength(500)]
        public string ProductDescription { get; set; }

        // ntext → dùng string
        public string Detail { get; set; }

        public int ViewCount { get; set; }

        // Foreign Keys
        public int? CateID { get; set; }
        public int? BrandID { get; set; }
        public int? SupplierID { get; set; }

        [StringLength(50)]
        public string MetaKeywords { get; set; }

        [StringLength(50)]
        public string MetaDescription { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
