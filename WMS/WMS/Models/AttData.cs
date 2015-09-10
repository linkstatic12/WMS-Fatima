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
    
    public partial class AttData
    {
        public string EmpDate { get; set; }
        public Nullable<System.DateTime> AttDate { get; set; }
        public string EmpNo { get; set; }
        public Nullable<int> EmpID { get; set; }
        public string DutyCode { get; set; }
        public Nullable<System.TimeSpan> DutyTime { get; set; }
        public Nullable<System.DateTime> TimeIn { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
        public Nullable<short> WorkMin { get; set; }
        public Nullable<short> LateIn { get; set; }
        public Nullable<short> LateOut { get; set; }
        public Nullable<short> EarlyIn { get; set; }
        public Nullable<short> EarlyOut { get; set; }
        public Nullable<short> OTMin { get; set; }
        public Nullable<short> GZOTMin { get; set; }
        public Nullable<short> BreakMin { get; set; }
        public Nullable<System.TimeSpan> SLMin { get; set; }
        public Nullable<bool> StatusP { get; set; }
        public Nullable<bool> StatusAB { get; set; }
        public Nullable<bool> StatusLI { get; set; }
        public Nullable<bool> StatusLO { get; set; }
        public Nullable<bool> StatusEI { get; set; }
        public Nullable<bool> StatusEO { get; set; }
        public Nullable<bool> StatusOT { get; set; }
        public Nullable<bool> StatusGZOT { get; set; }
        public Nullable<bool> StatusGZ { get; set; }
        public Nullable<bool> StatusDO { get; set; }
        public Nullable<bool> StatusHD { get; set; }
        public Nullable<bool> StatusSL { get; set; }
        public Nullable<bool> StatusOD { get; set; }
        public Nullable<bool> StatusHL { get; set; }
        public Nullable<bool> StatusLeave { get; set; }
        public Nullable<bool> StatusMN { get; set; }
        public Nullable<bool> StatusIN { get; set; }
        public Nullable<bool> StatusBreak { get; set; }
        public Nullable<short> ShifMin { get; set; }
        public Nullable<bool> ShfSplit { get; set; }
        public Nullable<bool> ProcessIn { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> Tin0 { get; set; }
        public Nullable<System.DateTime> Tout0 { get; set; }
        public Nullable<System.DateTime> Tin1 { get; set; }
        public Nullable<System.DateTime> Tout1 { get; set; }
        public Nullable<System.DateTime> Tin2 { get; set; }
        public Nullable<System.DateTime> Tout2 { get; set; }
        public Nullable<System.DateTime> Tin3 { get; set; }
        public Nullable<System.DateTime> Tout3 { get; set; }
        public Nullable<System.DateTime> Tin4 { get; set; }
        public Nullable<System.DateTime> Tout4 { get; set; }
        public Nullable<System.DateTime> Tin5 { get; set; }
        public Nullable<System.DateTime> Tout5 { get; set; }
        public Nullable<System.DateTime> Tin6 { get; set; }
        public Nullable<System.DateTime> Tout6 { get; set; }
        public Nullable<System.DateTime> Tin7 { get; set; }
        public Nullable<System.DateTime> Tout7 { get; set; }
        public Nullable<System.DateTime> Tin8 { get; set; }
        public Nullable<System.DateTime> Tout8 { get; set; }
        public Nullable<System.DateTime> Tin9 { get; set; }
        public Nullable<System.DateTime> Tout9 { get; set; }
        public Nullable<System.DateTime> Tin10 { get; set; }
        public Nullable<System.DateTime> Tout10 { get; set; }
        public Nullable<System.DateTime> Tin11 { get; set; }
        public Nullable<System.DateTime> Tout11 { get; set; }
        public Nullable<System.DateTime> Tin12 { get; set; }
        public Nullable<System.DateTime> Tout12 { get; set; }
        public Nullable<System.DateTime> Tin13 { get; set; }
        public Nullable<System.DateTime> Tout13 { get; set; }
        public Nullable<System.DateTime> Tin14 { get; set; }
        public Nullable<System.DateTime> Tout14 { get; set; }
        public Nullable<System.DateTime> Tin15 { get; set; }
        public Nullable<System.DateTime> Tout15 { get; set; }
    
        public virtual Emp Emp { get; set; }
    }
}
