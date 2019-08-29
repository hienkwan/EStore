using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectASPDotnet.Areas.Admin.Models
{
    public partial class Account
    {
        [Display(Name ="Account ID")]
        [Required]
        public int AccountId { get; set; }
        [Display(Name ="User name")]
        [Required]
        public string UserName { get; set; }
        [Display(Name ="Password")]
        [Required]
        public string Password { get; set; }
        [Display(Name ="Registration Date")]
        [Required]
        public DateTime RegisterDate { get; set; }
        [Display(Name ="Account Type")]
        [Required]
        public bool AccountType { get; set; }
        [Display(Name ="Email address")]
        [Required]
        public string Email { get; set; }
        public AccountInfo AccountInfo { get; set; }
    }
}
