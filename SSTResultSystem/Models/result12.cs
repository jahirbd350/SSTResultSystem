//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSTResultSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class result12
    {
        public int id { get; set; }
        public string studentid { get; set; }
        public string examterm { get; set; }
        public Nullable<double> mat1231 { get; set; }
        public Nullable<double> hum1222 { get; set; }
        public Nullable<double> eee1233 { get; set; }
        public Nullable<double> eee12p4 { get; set; }
        public Nullable<double> cse1235 { get; set; }
        public Nullable<double> cse12p6 { get; set; }
        public Nullable<double> cse1237 { get; set; }
        public Nullable<double> cse12p8 { get; set; }
    
        public virtual student student { get; set; }
    }
}
