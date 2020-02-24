using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCompany
    {
        public TblCompany()
        {
            InverseParent = new HashSet<TblCompany>();
            TblCustomerblacklist = new HashSet<TblCustomerblacklist>();
            TblInsertcustomerprofile = new HashSet<TblInsertcustomerprofile>();
        }

        public int Companyid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public decimal? Shareholdersfund { get; set; }
        public decimal? PreliminaryevaluationLimit { get; set; }
        public DateTime? Dateofincorporation { get; set; }
        public int? Countryid { get; set; }
        public short? Currencyid { get; set; }
        public short? Natureofbusinessid { get; set; }
        public string Nameofscheme { get; set; }
        public string Functionsregistered { get; set; }
        public decimal? Authorisedsharecapital { get; set; }
        public string Nameofregistrar { get; set; }
        public string Nameoftrustees { get; set; }
        public string Formermanagerstrustees { get; set; }
        public DateTime? Dateofrenewalofregistration { get; set; }
        public DateTime? Dateofcommencement { get; set; }
        public int? Initialfloatation { get; set; }
        public int? Initialsubscription { get; set; }
        public string Registeredby { get; set; }
        public string Trusteesaddress { get; set; }
        public string Investmentobjective { get; set; }
        public string Website { get; set; }
        public string Ebusinesscode { get; set; }
        public string Eoyprofitandlossgl { get; set; }
        public short? Companyclassid { get; set; }
        public short? Companytypeid { get; set; }
        public short? Accountingstandardid { get; set; }
        public short? Managementtypeid { get; set; }
        public int? Parentid { get; set; }
        public string Logopath { get; set; }
        public int? Createdby { get; set; }
        public int? Lastupdatedby { get; set; }
        public DateTime? Datetimecreated { get; set; }
        public DateTime? Datetimeupdated { get; set; }
        public byte[] Companylogo { get; set; }

        public TblCompanyclass Companyclass { get; set; }
        public TblCompanytype Companytype { get; set; }
        public TblCountry Country { get; set; }
        public TblCurrency Currency { get; set; }
        public TblNatureofbusiness Natureofbusiness { get; set; }
        public TblCompany Parent { get; set; }
        public ICollection<TblCompany> InverseParent { get; set; }
        public ICollection<TblCustomerblacklist> TblCustomerblacklist { get; set; }
        public ICollection<TblInsertcustomerprofile> TblInsertcustomerprofile { get; set; }
    }
}
