using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCORE.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [Display(Name = "Mã Sản phẩm" )]
        public string Id { get; set; }
        [Display(Name = "Tên sản phẩm" )]
        public string Name { get; set; }
        [Display(Name = "Đơn giá")]
        public string UnitPrice { get; set; }
        [Display(Name = "Số lượng" )]
        public string Quantity { get; set; }


    }
}