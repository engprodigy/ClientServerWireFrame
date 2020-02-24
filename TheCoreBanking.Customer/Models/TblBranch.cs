using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblBranch
    {
        public TblBranch()
        {
            TblCustomer = new HashSet<TblCustomer>();
            TblDepartment = new HashSet<TblDepartment>();
            TblEditedcustomer = new HashSet<TblEditedcustomer>();
        }

        public int Branchid { get; set; }
        public int Companyid { get; set; }
        public string Branchname { get; set; }
        public string Branchcode { get; set; }
        public string Addressline1 { get; set; }
        public string Addressline2 { get; set; }
        public string Comment { get; set; }
        public int? Stateid { get; set; }
        public int? Lgaid { get; set; }
        public int? Cityid { get; set; }
        public bool NplLimitexceeded { get; set; }
        public bool Deleted { get; set; }
        public int? Deletedby { get; set; }
        public DateTime? Datetimedeleted { get; set; }
        public int? Createdby { get; set; }
        public int? Lastupdatedby { get; set; }
        public DateTime? Datetimecreated { get; set; }
        public DateTime? Datetimeupdated { get; set; }

        public TblCity City { get; set; }
        public TblStateandlga Lga { get; set; }
        public TblState State { get; set; }
        public ICollection<TblCustomer> TblCustomer { get; set; }
        public ICollection<TblDepartment> TblDepartment { get; set; }
        public ICollection<TblEditedcustomer> TblEditedcustomer { get; set; }
    }
}
