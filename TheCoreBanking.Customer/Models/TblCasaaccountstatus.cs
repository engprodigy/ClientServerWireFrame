using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCasaaccountstatus
    {
        public TblCasaaccountstatus()
        {
            TblCasa = new HashSet<TblCasa>();
        }

        public int Accountstatusid { get; set; }
        public string Accountstatusname { get; set; }

        public ICollection<TblCasa> TblCasa { get; set; }
    }
}
