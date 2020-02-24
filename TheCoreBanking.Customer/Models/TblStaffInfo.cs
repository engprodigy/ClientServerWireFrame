using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblStaffInfo
    {
        public int Id { get; set; }
        public string CoyId { get; set; }
        public string StaffNo { get; set; }
        public string MisCode { get; set; }
        public string BranchId { get; set; }
        public string StaffName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string Rank { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? Age { get; set; }
        public string Gender { get; set; }
        public string NameOfNok { get; set; }
        public string PhoneOfNok { get; set; }
        public string EmailOfNok { get; set; }
        public string AddrOfNok { get; set; }
        public string GenderOfNok { get; set; }
        public string Comment { get; set; }
        public string State { get; set; }
        public string Nationality { get; set; }
        public string RelationShip { get; set; }
        public bool? Updated { get; set; }
        public byte[] Staffsignature { get; set; }
        public string DeptCode { get; set; }
        public string UnitCode { get; set; }
        public string Unit { get; set; }
        public string PcCode { get; set; }
    }
}
