using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAppraisalOfficers
    {
        public int Id { get; set; }
        public string CreditAppraisalOfficersId { get; set; }
        public string DepartmentId { get; set; }
        public string UnitId { get; set; }
        public string CoyId { get; set; }
        public string UserName { get; set; }
        public DateTime? DateLastModified { get; set; }
        public string CreatedBy { get; set; }
        public string DepartmentName { get; set; }
    }
}
