using FinalProjectASPDotnet.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectASPDotnet.Models
{
    public class Depot
    {
        [Display(Name ="Mã kho hàng")]
        [Required]
        public int DepotId { get; set; }
        [Display(Name ="Số lượng")]
        public int Quantity { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
