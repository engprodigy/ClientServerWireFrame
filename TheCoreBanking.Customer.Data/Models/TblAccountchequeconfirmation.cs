using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblAccountchequeconfirmation
    {
        public int Id { get; set; }
        public string Accountno { get; set; }
        public decimal? Amount { get; set; }
        public string Beneficiaryname { get; set; }
        public string Chequeno { get; set; }
        public string Confirmedfrom { get; set; }
        public string Phonenumber { get; set; }
        public string Confirmedby { get; set; }
        public bool Isapproved { get; set; }
        public bool Isconfirmed { get; set; }
        public DateTime? Dateconfirmed { get; set; }
        public byte[] Companycode { get; set; }
        public string Branchcode { get; set; }
    }
}
