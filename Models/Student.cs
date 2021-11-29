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
        [StringLength(20, MinimumLength = 3)]
        [Required]
        [Display(Name = "Mã Sinh viên" )]
        public string Id { get; set; }
        [RegularExpression(@"[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Tên sinh viên" )]
        public string Name { get; set; }
        [Required]
        [StringLength(60)]
        [Display(Name = "Địa chỉ" )]
        public string Address { get; set; }
        [Required]
        [StringLength(60)]
        [Display(Name = "Trường học" )]
        public string School {get; set;}
        public ICollection<KetQua> KetQuas { get; set; }
    }
}