using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectASPDotnet.Areas.Admin.Models
{
    public class AccountInfo
    {
        
        [Display(Name ="ID Thông tin tài khoản")]
        public int AccountInfoId { get; set; }
        [Display(Name ="Họ tên")]
        public string FullName { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Số điện thoại")]
        public string PhoneNumer { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        public int AccountId { get; set; }
        //admin or user or nonresident
        public string AccountType { get; set; }
    }
}
