//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_commerce
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Desc { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Category { get; set; }
    
        public virtual Catagory Catagory { get; set; }
    }
}
