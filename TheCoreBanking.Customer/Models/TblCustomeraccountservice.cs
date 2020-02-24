using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCustomeraccountservice
    {
        public TblCustomeraccountservice()
        {
            TblCustomeraccountalertmedium = new HashSet<TblCustomeraccountalertmedium>();
            TblCustomeraccountbankingservice = new HashSet<TblCustomeraccountbankingservice>();
            TblCustomeraccountstmntmedium = new HashSet<TblCustomeraccountstmntmedium>();
        }

        public int Id { get; set; }
        public int Casaaccountid { get; set; }
        public int? Cardtypeid { get; set; }
        public string Nameoncard { get; set; }
        public int? Statementfrequencyid { get; set; }
        public decimal? Minbalance { get; set; }

        public TblAccountcardtype Cardtype { get; set; }
        public TblCasa Casaaccount { get; set; }
        public TblAccountstmntfreq Statementfrequency { get; set; }
        public ICollection<TblCustomeraccountalertmedium> TblCustomeraccountalertmedium { get; set; }
        public ICollection<TblCustomeraccountbankingservice> TblCustomeraccountbankingservice { get; set; }
        public ICollection<TblCustomeraccountstmntmedium> TblCustomeraccountstmntmedium { get; set; }
    }
}
