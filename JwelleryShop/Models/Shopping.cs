using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JwelleryShop.Models
{
    public class ShoppingDetail
    {
        public int shippingDetailId { get; set; }
        [Required]
        public Nullable<int> memberId { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string zipcode { get; set; }
        public Nullable<int> orderId { get; set; }
        public Nullable<decimal> amountPaid { get; set; }
        [Required]
        public string paymentType { get; set; }

        
    }
}