using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCORE.Models
{
    [Table("KetQuas")]
    public class KetQua
    {
        [Key]
        [Display(Name = "Mã Sinh viên" )]
        public string Id { get; set; }
        [Display(Name = "Mã môn học" )]
        public string MaMonHocID { get; set; }
        [Display(Name = "Điểm" )]
        public string Diem { get; set; }
        public Student Student { get; set; }
    }
}