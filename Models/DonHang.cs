using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCORE.Models
{
    public class DonHang : Person
    {
        [Display(Name = "Mã đơn hàng")]
        public string DonHangID { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }

    }
}