using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCORE.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        [Display(Name = "Mã nhân viên" )]
        public string Id { get; set; }
        [Display(Name = "Tên nhân viên" )]
        public string Name { get; set; }
        [Display(Name = "Số điện thoại" )]
        public string PhoneNumber { get; set; }
    }
}