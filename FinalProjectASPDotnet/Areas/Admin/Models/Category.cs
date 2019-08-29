using FinalProjectASPDotnet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectASPDotnet.Areas.Admin.Models
{
    public partial class Category
    {
        [Display(Name ="ID loại")]
        [Required]
        [Key]
        public int CateID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Product> product { get; set; }
    }
}
