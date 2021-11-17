using System.Collections.Generic;
using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCORE.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]

        [Display(Name = "Mã Sinh viên" )]
        public string Id { get; set; }
        [Display(Name = "Tên sinh viên" )]
        public string Name { get; set; }
        [Display(Name = "Địa chỉ" )]
        public string Address { get; set; }
        public ICollection<KetQua> KetQuas { get; set; }
    }
}