//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL_Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class Issue
    {
        public decimal Lib_Issue_Id { get; set; }
        public Nullable<decimal> Book_No { get; set; }
        public Nullable<decimal> MemberId { get; set; }
        public Nullable<System.DateTime> Issue_Date { get; set; }
        public Nullable<System.DateTime> Return_Date { get; set; }
        public string status { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Member Member { get; set; }
    }
}
