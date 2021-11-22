using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCORE.Models
{
    public class HoaDon : Product
    {
        [Display(Name = "Mã Hóa Đơn" )]
        public string IdHoaDon { get; set; }
        [Display(Name = "Nhân viên")]
        public string NhanVien { get; set; }

    }
}