//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Corporate_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public System.Guid Id { get; set; }
        public decimal Amount { get; set; }
        public System.Guid ClientId { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
