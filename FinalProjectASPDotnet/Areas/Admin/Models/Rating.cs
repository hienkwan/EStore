using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectASPDotnet.Areas.Admin.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int ProductId { get; set; }
        [Display(Name ="Bình luận")]
        [MaxLength]
        public string Comment { get; set; }
        public int Ratings { get; set; }

    }
}
