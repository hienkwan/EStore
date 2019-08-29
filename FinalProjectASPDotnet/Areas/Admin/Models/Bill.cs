using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectASPDotnet.Areas.Admin.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillDetails = new HashSet<BillDetails>();
        }
        [Display(Name ="Mã hóa đơn ")]
        [Required]
        public int BillId { get; set; }
        [Display(Name ="Ngày lập đơn")]
        [Required]
        public DateTime CreateDate { get; set; }
        [Display(Name ="Tên khách hàng")]
        [Required]
        public string CustomerName { get; set; }
        [Display(Name ="Địa chỉ")]
        [Required]
        public string CustomerAddress { get; set; }
        [Display(Name ="Số điện thoại")]
        [Required]
        public string CustomerPhone { get; set; }
        [Display(Name ="Địa chỉ Email")]
        [Required]
        public string CustomerEmail { get; set; }
        public bool Status { get; set; }
        public Account Account { get; set; }
        public ICollection<BillDetails> BillDetails { get; set; }
    }
}
