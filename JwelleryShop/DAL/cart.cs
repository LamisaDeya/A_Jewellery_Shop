//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JwelleryShop.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class cart
    {
        public int cartId { get; set; }
        public Nullable<int> productId { get; set; }
        public Nullable<int> memberId { get; set; }
        public Nullable<int> cartStatusId { get; set; }
    
        public virtual product product { get; set; }
    }
}
