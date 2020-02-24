using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblEditedcustomer
    {
        public int Customerid { get; set; }
        public string Customercode { get; set; }
        public int Branchid { get; set; }
        public int? Genderid { get; set; }
        public int? Titleid { get; set; }
        public int? Modeofidentificationid { get; set; }
        public int? Stateandlgaid { get; set; }
        public int? Maritalstatusid { get; set; }
        public int? Annualincomeid { get; set; }
        public int Companyid { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public DateTime? Dateofbirth { get; set; }
        public string Placeofbirth { get; set; }
        public string Nationality { get; set; }
        public int? Maritalstatus { get; set; }
        public string Emailaddress { get; set; }
        public string Maidenname { get; set; }
        public string Spouse { get; set; }
        public string Occupation { get; set; }
        public short? Customeraccounttypeid { get; set; }
        public int? Relationshipofficerid { get; set; }
        public bool Ispoliticallyexposed { get; set; }
        public bool Isinvestmentgrade { get; set; }
        public bool Isrealatedparty { get; set; }
        public string Miscode { get; set; }
        public string Misstaff { get; set; }
        public int? Approvalstatus { get; set; }
        public DateTime? Dateactedon { get; set; }
        public string Actedonby { get; set; }
        public short Customersensitivitylevelid { get; set; }
        public short? Subsectorid { get; set; }
        public short? Fscaptiongroupid { get; set; }
        public string Taxnumber { get; set; }
        public string Customerbvn { get; set; }
        public short? Riskratingid { get; set; }
        public int Createdby { get; set; }
        public int? Lastupdatedby { get; set; }
        public DateTime Datetimecreated { get; set; }
        public DateTime? Datetimeupdated { get; set; }
        public bool Deleted { get; set; }
        public int? Deletedby { get; set; }
        public DateTime? Datetimedeleted { get; set; }

        public TblAnnualincome Annualincome { get; set; }
        public TblBranch Branch { get; set; }
        public TblAnnualincome Customer { get; set; }
        public TblGender GenderNavigation { get; set; }
        public TblMaritalstatus MaritalstatusNavigation { get; set; }
        public TblModeofidentification Modeofidentification { get; set; }
        public TblStaff Relationshipofficer { get; set; }
        public TblTitle TitleNavigation { get; set; }
    }
}
