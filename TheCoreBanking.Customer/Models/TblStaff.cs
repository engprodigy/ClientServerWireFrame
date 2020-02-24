using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblStaff
    {
        public TblStaff()
        {
            TblCustomer = new HashSet<TblCustomer>();
            TblEditedcustomer = new HashSet<TblEditedcustomer>();
        }

        public int Staffid { get; set; }
        public string Staffcode { get; set; }
        public int Companyid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public int Jobtitleid { get; set; }
        public int Rankid { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? Dateofbirth { get; set; }
        public string Gender { get; set; }
        public string Nameofnok { get; set; }
        public string Phoneofnok { get; set; }
        public string Emailofnok { get; set; }
        public string Addressofnok { get; set; }
        public string Genderofnok { get; set; }
        public string Nokrelationship { get; set; }
        public string Comment { get; set; }
        public short? Branchid { get; set; }
        public int? Misinfoid { get; set; }
        public short? Departmentid { get; set; }
        public short? DepartmentUnitid { get; set; }
        public int? Stateid { get; set; }
        public int? Cityid { get; set; }
        public short Customersensitivitylevel { get; set; }
        public bool NplLimitexceeded { get; set; }
        public int? Createdby { get; set; }
        public int? Lastupdatedby { get; set; }
        public DateTime? Datetimecreated { get; set; }
        public DateTime? Datetimeupdated { get; set; }
        public bool Deleted { get; set; }
        public int? Deletedby { get; set; }
        public DateTime? Datetimedeleted { get; set; }

        public TblCity City { get; set; }
        public TblStaffjobtitle Jobtitle { get; set; }
        public TblStaffrank Rank { get; set; }
        public ICollection<TblCustomer> TblCustomer { get; set; }
        public ICollection<TblEditedcustomer> TblEditedcustomer { get; set; }
    }
}
