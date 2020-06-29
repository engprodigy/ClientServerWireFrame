using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblStaffInformation
    {
        public long Id { get; set; }
        public string CompanyId { get; set; }
        public string StaffNo { get; set; }
        public string Miscode { get; set; }
        public string BranchId { get; set; }
        public string StaffName { get; set; }
        public string Department { get; set; }
        public int DesignationCode { get; set; }
        public string JobTitle { get; set; }
        public string Rank { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Age { get; set; }
        public string Gender { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinPhone { get; set; }
        public string NextOfKinEmail { get; set; }
        public string NextOfKinAddress { get; set; }
        public string NextOfKinGender { get; set; }
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
        public string ImageData { get; set; }
        public string ImageTitle { get; set; }
    }
}
