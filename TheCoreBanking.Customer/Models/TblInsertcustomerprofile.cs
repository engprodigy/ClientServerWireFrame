using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblInsertcustomerprofile
    {
        public int Id { get; set; }
        public string Customercode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public bool PoliticallyExposed { get; set; }
        public string HomeTown { get; set; }
        public DateTime? Idexpiry { get; set; }
        public string IdentificationNumber { get; set; }
        public string ResidentialAddress { get; set; }
        public string IdplaceOfIssue { get; set; }
        public string IdissueAuthority { get; set; }
        public string SpouseName { get; set; }
        public string EducationLevel { get; set; }
        public DateTime? MarriageCertificationDate { get; set; }
        public string SpousePhone { get; set; }
        public string SpouseEmail { get; set; }
        public string NameOfFirstChild { get; set; }
        public DateTime? FirstChildDob { get; set; }
        public string ForeignResidentialPermitNo { get; set; }
        public string NextOfKinFirstName { get; set; }
        public string NextOfKinLastname { get; set; }
        public string NextOfKinOtherName { get; set; }
        public DateTime? NextOfKinDob { get; set; }
        public int? NextOfKinGender { get; set; }
        public string NextOfKinEmail { get; set; }
        public string NextOfKinPhone { get; set; }
        public string NextOfKinRelationship { get; set; }
        public string NextOfKinAddress { get; set; }
        public int? EmploymentType { get; set; }
        public string Occupation { get; set; }
        public string CurrentEmployer { get; set; }
        public string EmployerAddress { get; set; }
        public string EmployerTelephone { get; set; }
        public int? EmployerState { get; set; }
        public int? EmployerCountry { get; set; }
        public DateTime? EmploymentDate { get; set; }
        public string PreviousEmployer { get; set; }
        public int? AnnualIncome { get; set; }
        public string Bvn { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public int? BankAccountTypeId { get; set; }
        public string BankAccountNo { get; set; }
        public int GenderId { get; set; }
        public int RegionId { get; set; }
        public int? Rbscategory { get; set; }
        public int? ProcessTypeId { get; set; }
        public int? TitleId { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? NationalityId { get; set; }
        public int? Lgaid { get; set; }
        public int? CompanyId { get; set; }
        public int? StateId { get; set; }
        public int? ModeOfIdentityId { get; set; }

        public TblBankaccounttype BankAccountType { get; set; }
        public TblCompany Company { get; set; }
        public TblGender Gender { get; set; }
        public TblStateandlga Lga { get; set; }
        public TblMaritalstatus MaritalStatus { get; set; }
        public TblModeofidentification ModeOfIdentity { get; set; }
        public TblCountry Nationality { get; set; }
        public TblRegion Region { get; set; }
        public TblState State { get; set; }
        public TblTitle Title { get; set; }
    }
}
