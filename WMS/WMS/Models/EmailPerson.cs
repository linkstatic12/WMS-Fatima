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
    
    public partial class EmailPerson
    {
        public int EmailID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Nullable<short> SecDeptID { get; set; }
        public string CCEmail1 { get; set; }
        public string CCEmail2 { get; set; }
        public string CCEmail3 { get; set; }
        public Nullable<bool> SecDeptWise { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<short> LocationID { get; set; }
        public Nullable<short> EmpTypeID { get; set; }
    }
}
