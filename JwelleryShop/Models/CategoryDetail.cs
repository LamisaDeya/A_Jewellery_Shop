using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JwelleryShop.Models
{
    public class CategoryDetail
    {
        public int categoryId { get; set; }
        [Required(ErrorMessage ="Category name is required")]
        [StringLength(100,ErrorMessage ="Minimum 3 and minimum 5 and maximum 100 characters are allowed",MinimumLength =3)]
        public string categoryName { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<bool> isDelete { get; set; }
    }
    public class ProductDetail
    {
        public int productId { get; set; }
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, ErrorMessage = "Minimum 3 and minimum 5 and maximum 100 characters are allowed", MinimumLength = 3)]
        public string productName { get; set; }
        [Required]
        [Range(1,50)]
        public Nullable<int> categoryId { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<bool> isDelete { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> modifiedDate { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public Nullable<System.DateTime> description { get; set; }
        
        public string productImage { get; set; }
        public Nullable<bool> isFeatured { get; set; }
        [Required]
        [Range(typeof(int),"1","500",ErrorMessage ="Invalid Quantity")]
        public Nullable<int> quantity { get; set; }
        [Required]
        [Range(typeof(int), "1", "2000000", ErrorMessage = "Invalid Price")]
        public Nullable<decimal> price { get; set; }
        public SelectList Categories { get; set; }
    }
}