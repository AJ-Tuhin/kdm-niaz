//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_notification
    {
        public long notf_id { get; set; }
        public string notf_type { get; set; }
        public Nullable<long> notf_ref { get; set; }
        public string notf_title { get; set; }
        public string notf_to { get; set; }
        public string notf_to_email { get; set; }
        public string notf_from { get; set; }
        public string notf_message { get; set; }
        public string notf_status { get; set; }
        public Nullable<System.DateTime> notf_time { get; set; }
        public Nullable<System.DateTime> notf_read_time { get; set; }
        public string notf_user_by { get; set; }
    }
}
