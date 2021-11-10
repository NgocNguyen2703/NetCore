using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCORE.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        [Display(Name = "Mã KH" )]
        public string Id { get; set; }
        [Display(Name = "Tên KH" )]
        public string Name { get; set; }
    }
}