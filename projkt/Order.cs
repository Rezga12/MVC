//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projkt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public int company_id { get; set; }
        public int total_amount { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Rating { get; set; }
    }
}
