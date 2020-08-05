using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KDM.Models
{
    public class MemberRegistrationViewModel
    {

        public Int64 ID { get; set; }
        public Int64 SponsorID { get; set; }
        public string SponsorName { get; set; }
        public int Position { get; set; }
        public string DistributorName { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string NID { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string NomineeName { get; set; }
        public string RelationWithNominee { get; set; }
        public string NomineeNIDOrBirthCertificate { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public Int64 PhotoID { get; set; }
        public HttpPostedFileBase Photo { get; set; }


    }
    
}