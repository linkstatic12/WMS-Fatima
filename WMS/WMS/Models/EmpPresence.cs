//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpPresence
    {
        public int EmpID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> TimeIn { get; set; }
        public Nullable<System.TimeSpan> TimeOut { get; set; }
        public Nullable<short> ReaderIn { get; set; }
        public Nullable<short> ReaderOut { get; set; }
        public Nullable<bool> StatusIn { get; set; }
        public Nullable<bool> StatusOut { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
