using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblMandate
    {
        public int Mandateid { get; set; }
        public int Casaaccountid { get; set; }
        public string Signatorysurname { get; set; }
        public string Signatoryothername { get; set; }
        public string Signatoryfirstname { get; set; }
        public string Signatoryaddress { get; set; }
        public string Signatoryaddress2 { get; set; }
        public string Signatoryphone { get; set; }
        public string Signatoryphone2 { get; set; }
        public string Signatoryphone3 { get; set; }
        public string Signatoryclass { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Signatorydob { get; set; }
        public DateTime? Signatorywedding { get; set; }
        public int? Signatorytitleid { get; set; }
        public string Signatoryemail { get; set; }
        public int? Signatorymodeofid { get; set; }
        public string Signatorydesignation { get; set; }
        public DateTime? Dateofarrival { get; set; }
        public DateTime? Dateofdeparture { get; set; }
        public DateTime? Visavalidfrom { get; set; }
        public DateTime? Visavalidto { get; set; }
        public string Passportno { get; set; }
        public DateTime? Passportissuedate { get; set; }
        public DateTime? Passportexpirydate { get; set; }
        public string Residentpermitno { get; set; }
        public string Pin { get; set; }
        public string Bvn { get; set; }
        public bool Isdeleted { get; set; }

        public TblCasa Casaaccount { get; set; }
    }
}
