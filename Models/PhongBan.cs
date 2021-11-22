using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCORE.Models
{
    public class PhongBan : Employee
    {
        [Display(Name = "Mã Phòng Ban" )]
        public string IdPhong { get; set; }
        [Display(Name = "Tên Phòng Ban" )]
        public string Name { get; set; }
        [Display(Name = "Địa Chỉ" )]
        public string Address { get; set; }
    }
}