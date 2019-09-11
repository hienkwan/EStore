using FinalProjectASPDotnet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectASPDotnet.Areas.Admin.Models
{
    public partial class Product
    {
        public Product()
        {
            BillDetail = new HashSet<BillDetails>();
            Depot = new HashSet<Depot>();
            TopSelling = new HashSet<TopSelling>();

        }
        [Display(Name = "Mã Hàng Hóa")]
        [Required]
        public int  ProductId { get; set; }
        [Display(Name = "Tên hàng hóa")]
        [Required]
        public string ProductName { get; set; }
        public int CateId  { get; set; }
        [Display(Name = "Giá")]
        [Required]
        public double Price { get; set; }
        [Display(Name = "Hình")]
        [Required]
        public string Image { get; set; }
        [Display(Name = "Mô tả")]
        [Required]
        public string Describe { get; set; }
        public Category category { get; set; }
        public ICollection<BillDetails> BillDetail { get; set; }
        public ICollection<Depot> Depot { get; set; }
        public ICollection<TopSelling> TopSelling { get; set; }
        public string CategoryNameSeoUrl => category.CategoryName.ToUrlFriendly();

    }
}
