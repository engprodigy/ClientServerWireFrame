using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Data.Models
{
    public partial class TblDepartment
    {
        public int Id { get; set; }
        public int? Companyid { get; set; }
        public int? Branchid { get; set; }
        public string Department { get; set; }
        public string Departmentcode { get; set; }
        public string Unitcode { get; set; }
        public string Unitname { get; set; }

        public TblBranch Branch { get; set; }
    }
}
