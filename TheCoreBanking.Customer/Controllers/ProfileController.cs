using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;
using TheCoreBanking.Customer.ViewModels;

namespace TheCoreBanking.Customer.Controllers
{
    public class ProfileController : Controller
    {
        private ICustomerUnitOfWork CustomerUnitOfWork { get; }
        private readonly IHostingEnvironment hostingEnvironment;
        private ILogger<ProfileController> logger;

        public ProfileController(IHostingEnvironment hostingEnvironment, 
            ICustomerUnitOfWork uow, ILogger<ProfileController> profileLogger)
        {
            CustomerUnitOfWork = uow;
            this.hostingEnvironment = hostingEnvironment;
            logger = profileLogger;
        }

#if DEBUG
        //[Authorize()]
#else
            [Authorize()]
#endif
        public IActionResult Index()
        {
            logger.LogInformation("Index method called");
            return View();
        }

#if DEBUG
        //[Authorize()]
#else
            [Authorize()]
#endif
        public IActionResult KYCStatus()
        {
            return View();
        }
        [HttpGet]
        public JsonResult lstCustomFields()
        {
            List<TblCustomerCustomFields> customList = new List<TblCustomerCustomFields>();
            var result = CustomerUnitOfWork.CustomFields.GetAll().ToList();
            if(result != null)
            {
                foreach (var item in result)
                {
                    var addList = new TblCustomerCustomFields()
                    {
                        Caption1 = item.Caption1,
                        Caption2 = item.Caption2,
                        Caption3 = item.Caption3,
                        Caption4 = item.Caption4,
                        Caption5 = item.Caption5,
                        Caption6 = item.Caption6,
                        Caption7 = item.Caption7,
                        Caption8 = item.Caption8,
                        Caption9 = item.Caption9,
                        Caption10 = item.Caption10,
                        Caption11 = item.Caption11,
                        Caption12 = item.Caption12,
                        Caption13 = item.Caption13,
                        Caption14 = item.Caption14,
                        Caption15 = item.Caption15,
                        Caption16 = item.Caption16,
                        Caption17 = item.Caption17,
                        Caption18 = item.Caption18,
                        Caption19 = item.Caption19,
                        Caption20 = item.Caption20
                    };
                    customList.Add(addList);
                }
            }
            return Json(customList);
        }

        #region Create

        public JsonResult AddCustomer([FromBody]AddCustomerVM customerinfo)
        {
            CustomerUnitOfWork.Customers.Add(customerinfo.customer);
            CustomerUnitOfWork.Commit();
            if (customerinfo.emails != null)
            {
                foreach(var item in customerinfo.emails)
                {
                    item.Customerid = customerinfo.customer.Customerid;
                    CustomerUnitOfWork.CustomerEmails.Add(item);
                }
            }
            if (customerinfo.addresses != null)
            {
                foreach (var item in customerinfo.addresses)
                {
                    item.Customerid = customerinfo.customer.Customerid;
                    CustomerUnitOfWork.CustomerAddresses.Add(item);
                }
            }
            if (customerinfo.phones != null)
            {
                foreach (var item in customerinfo.phones)
                {
                    item.Customerid = customerinfo.customer.Customerid;
                    CustomerUnitOfWork.CustomerPhones.Add(item);
                }
            }
            if (customerinfo.kyc != null)
            {
                foreach(var item in customerinfo.kyc)
                {
                    item.Customerid = customerinfo.customer.Customerid;
                    CustomerUnitOfWork.CustomerKYCItems.Add(item);
                }
            }
            CustomerUnitOfWork.Commit();
            GenerateCustomerCode(customerinfo.customer.Customerid);
            return Json(customerinfo.customer.Customerid);
        }

        public JsonResult AddCustomerAddress([FromBody]TblCustomeraddress address)
        {

            CustomerUnitOfWork.CustomerAddresses.Add(address);
            CustomerUnitOfWork.Commit();
            var result = CustomerUnitOfWork
                .CustomerAddresses.GetDetailedByCustomerId(address.Customerid);
            return Json(result);
        }

        public JsonResult AddCustomerPhone([FromBody]TblCustomerphonecontact phone)
        {
            CustomerUnitOfWork.CustomerPhones.Add(phone);
            CustomerUnitOfWork.Commit();
            var result = CustomerUnitOfWork
                .CustomerPhones.GetByCustomerId(phone.Customerid);
            return Json(result);
        }

        public JsonResult AddCustomerEmail([FromBody]TblCustomeremailcontact email)
        {
            CustomerUnitOfWork.CustomerEmails.Add(email);
            CustomerUnitOfWork.Commit();
            var result = CustomerUnitOfWork
                .CustomerEmails.GetByCustomerId(email.Customerid);
            return Json(result);
        }

        [HttpPost]
        public JsonResult AddKYCUpload(int id, KYCDocumentVM upload, bool sendall)
        {
            List<TblKycdocuments> files = null;
            using (var db = new TheCoreBankingFileContext())
            using (var stream = new MemoryStream())
            {
                upload.Document.CopyTo(stream);
                TblKycdocuments kycdocument = new TblKycdocuments
                {
                    Filedata = stream.ToArray(),
                    Customerid = id,
                    Title = upload.Title,
                    Mime = upload.Document.ContentType,
                    Isdeleted = false
                };
                db.TblKycdocuments.Add(kycdocument);
                db.SaveChanges();
                if (sendall)
                {
                    files = db.TblKycdocuments
                        .Where(k => k.Customerid == id)
                        .Where(k => k.Isdeleted == false)
                        .Select(k => new TblKycdocuments
                        {
                            Id = k.Id,
                            Customerid = k.Customerid,
                            Title = k.Title,
                            Mime = k.Mime
                        }).ToList();
                }
            }
            if (sendall) { return Json(files); }
            return Json(true);
        }

        #endregion

        #region Update

         public JsonResult UpdateCustomer([FromBody]UpdateCustomerVM customerinfo)
       
        {

           

            CustomerUnitOfWork.Customers.Update(customerinfo.customer);
             if (customerinfo.kyc != null)
             {
                 var existingKYC = CustomerUnitOfWork
                     .CustomerKYCItems.GetByCustomerId(customerinfo.customer.Customerid);

                 List<TblCustomeraccountkycitem> updatedKYC
                     = new List<TblCustomeraccountkycitem>();
                 foreach (var newItem in customerinfo.kyc)
                 {
                     foreach (var existingItem in existingKYC)
                     {
                         if (newItem.Kycitemid == existingItem.Kycitemid)
                         {
                             //  Update existing items
                             existingItem.Actionid = newItem.Actionid;
                             existingItem.Actiondate = newItem.Actiondate;
                             CustomerUnitOfWork.CustomerKYCItems.Update(existingItem);
                             updatedKYC.Add(newItem);
                             break;
                         }
                     }
                 }
                 customerinfo.kyc.RemoveAll(k => updatedKYC.Contains(k));
                 // Add new items if they're not null
                 foreach (var item in customerinfo.kyc)
                 {
                     if (item.Actionid != null) {
                         CustomerUnitOfWork.CustomerKYCItems.Add(item);
                     }

                 }
             }

              CustomerUnitOfWork.Commit();
             return Json(customerinfo.customer.Customerid);
            
        }

        public JsonResult UpdateCustomerAddress([FromBody]TblCustomeraddress address)
        {
            CustomerUnitOfWork.CustomerAddresses.Update(address);
            CustomerUnitOfWork.Commit();
            var result = CustomerUnitOfWork
                .CustomerAddresses.GetDetailedByCustomerId(address.Customerid);
            return Json(result);
        }

        public JsonResult UpdateCustomerPhone([FromBody]TblCustomerphonecontact phone)
        {
            CustomerUnitOfWork.CustomerPhones.Update(phone);
            CustomerUnitOfWork.Commit();
            var result = CustomerUnitOfWork
                .CustomerPhones.GetByCustomerId(phone.Customerid);
            return Json(result);
        }

        public JsonResult UpdateCustomerEmail([FromBody]TblCustomeremailcontact email)
        {
            CustomerUnitOfWork.CustomerEmails.Update(email);
            CustomerUnitOfWork.Commit();
            var result = CustomerUnitOfWork
                .CustomerEmails.GetByCustomerId(email.Customerid);
            return Json(result);
        }

        #endregion   

        #region Fetch

        public JsonResult LoadCustomers()
        {
            var result = CustomerUnitOfWork.Customers.GetDetailed();    //.GetAll();
            return Json(result);
        }

        public JsonResult LoadCustomerAccountTypes()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.CustomerAccountTypes.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Name
                });
            }
            return Json(list);
        }

        public JsonResult LoadRegions()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.Regions.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Regionid.ToString(),
                    Text = item.Regionname
                });
            }
            return Json(list);
        }

        public JsonResult LoadSectors()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.Sectors.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Sectorid.ToString(),
                    Text = item.Name
                });
            }
            return Json(list);
        }

        public JsonResult LoadTitles()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.Titles.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Title
                });
            }
            return Json(list);
        }

        public JsonResult LoadSensitivityLevels()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.SensitivityLevels.GetActive();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Sensitivitylevel
                });
            }
            return Json(list);
        }

        public JsonResult LoadMaritalStatuses()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.MaritalStatuses.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Status
                });
            }
            return Json(list);
        }

        public JsonResult LoadGenders()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.Genders.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Name
                });
            }
            return Json(list);
        }

        public JsonResult LoadStates()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.States.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Stateid.ToString(),
                    Text = item.Statename
                });
            }
            return Json(list);
        }

        public JsonResult LoadModeOfIDs()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.ModeOfIDs.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Idmode
                });
            }
            return Json(list);
        }

        public JsonResult LoadCountries()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.Countries.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Countryid.ToString(),
                    Text = item.Name
                });
            }
            return Json(list);
        }

        public JsonResult LoadLGAs()
        {
            var list = new List<StateLGAs>();
            var result = CustomerUnitOfWork.StateLGAs.GetAll();
            foreach (var item in result)
            {
                list.Add(new StateLGAs
                {
                    ID = item.Id.ToString(),
                    State = item.State,
                    LGA = item.Lga
                });
            }
            return Json(list);
        }

        public JsonResult LoadIndustries()
        {
            var list = new List<SectorIndustries>();
            var result = CustomerUnitOfWork.Industries.GetAll();
            foreach (var item in result)
            {
                list.Add(new SectorIndustries
                {
                    Industryid = item.Industryid.ToString(),
                    Sectorid = item.Sectorid.ToString(),
                    Name = item.Name
                });
            }
            return Json(list);
        }

        public JsonResult LoadAnnualIncomes(string id)
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.AnnualIncomes.GetAll();
            if (!string.IsNullOrWhiteSpace(id))
            {
                if (id.ToLower() == "individual")
                    result = CustomerUnitOfWork.AnnualIncomes.GetIndividualType();
                else if (id.ToLower() == "business")
                    result = CustomerUnitOfWork.AnnualIncomes.GetBusinessType();
            }
            
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Range
                });
            }
            return Json(list);
        }

        public JsonResult LoadKYCItems(string id)
        {
            IQueryable<TblKycitem> result;

            if (!string.IsNullOrWhiteSpace(id))
            {
                switch (id.ToLower())
                {
                    case "individual":
                        result = CustomerUnitOfWork.KYCItems.GetIndividualItems();
                        break;
                    case "minor":
                        result = CustomerUnitOfWork.KYCItems.GetMinorItems();
                        break;
                    case "corporate":
                        result = CustomerUnitOfWork.KYCItems.GetCorporateItems();
                        break;
                    case "joint":
                        result = CustomerUnitOfWork.KYCItems.GetJointItems();
                        break;
                    case "estate":
                        result = CustomerUnitOfWork.KYCItems.GetEstateItems();
                        break;
                    case "unincorporated":
                        result = CustomerUnitOfWork.KYCItems.GetUnincorporatedItems();
                        break;
                    default:
                        result = CustomerUnitOfWork.KYCItems.GetAll();
                        break;
                }
            } else
            {
                result = CustomerUnitOfWork.KYCItems.GetAll();
            }
            
            List<KYCItems> list = new List<KYCItems>();
            foreach (var item in result)
            {
                list.Add(new KYCItems
                {
                    ID = item.Kycitemid.ToString(),
                    AccountType = item.Accounttype.Name,
                    DisplayOrder = item.Displayorder.ToString(),
                    Item = item.Item,
                    Mandatory = item.Ismandatory
                });
            }
            return Json(list);
        }

        public JsonResult LoadEmploymentTypes()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.EmploymentTypes.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Type
                });
            }
            return Json(list);
        }

        public JsonResult LoadInstitutionTypes()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.InstitutionTypes.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Typename
                });
            }
            return Json(list);
        }

        public JsonResult LoadKYCItemActions()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.KYCItemActions.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Action
                });
            }
            return Json(list);
        }

        public JsonResult LoadFundSources()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.SourceOfFunds.GetActive();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Source
                });
            }
            return Json(list);
        }

        public JsonResult LoadBanks()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.Banks.GetActive();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Name
                });
            }
            return Json(list);
        }

        public JsonResult LoadBankAccountTypes()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.BankAccountTypes.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Accounttype
                });
            }
            return Json(list);
        }

        public JsonResult LoadBusinessCategories()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.BusinessCategories.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Name
                });
            }
            return Json(list);
        }

        public JsonResult LoadAddressTypes()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.AddressTypes.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Addresstypeid.ToString(),
                    Text = item.AddressTypeName
                });
            }
            return Json(list);
        }

        public JsonResult LoadCustomerAddresses(string id)
        {
            if (!int.TryParse(id, out int customerID))
            {
                return null;
            }

            var result = CustomerUnitOfWork.CustomerAddresses
                .GetDetailedByCustomerId(customerID);
            return Json(result);
        }

        public JsonResult LoadCustomerPhones(string id)
        {
            if (!int.TryParse(id, out int customerID))
            {
                return null;
            }

            var result = CustomerUnitOfWork.CustomerPhones
                .GetByCustomerId(customerID);
            return Json(result);
        }

        public JsonResult LoadCustomerEmails(string id)
        {
            if (!int.TryParse(id, out int customerID))
            {
                return null;
            }

            var result = CustomerUnitOfWork.CustomerEmails
                .GetByCustomerId(customerID);
            return Json(result);
        }

        public JsonResult ListKYCUploads(int id)
        {
            List<TblKycdocuments> files;
            using (var db = new TheCoreBankingFileContext()) {
                files = db.TblKycdocuments
                    .Where(k => k.Customerid == id)
                    .Where(k => k.Isdeleted == false)
                    .Select(k => new TblKycdocuments {
                        Id = k.Id,
                        Customerid = k.Customerid,
                        Title = k.Title,
                        Mime = k.Mime
                    }).ToList();
            };
            return Json(files);
        }

        public IActionResult LoadKYCDocument(int id)
        {
            TblKycdocuments document;
            using (var db = new TheCoreBankingFileContext())
            {
                document = db.TblKycdocuments
                    .Where(k => k.Id == id)
                    .Where(k => k.Isdeleted == false)
                    .Select(k => new TblKycdocuments
                    {
                        Filedata = k.Filedata,
                        Mime = k.Mime
                    })
                    .SingleOrDefault();
            };
            if (document == null) return BadRequest();
            return File(document.Filedata, document.Mime);
        }

        #endregion

        #region Delete

        [HttpPost]
        public JsonResult DeleteKYCUpload(int id)
        {
            using (var db = new TheCoreBankingFileContext())
            {
                db.TblKycdocuments
                    .SingleOrDefault(k => k.Id == id)
                    .Isdeleted = true;
                db.SaveChanges();
            }
            return ListKYCUploads(id);
        }

        #endregion

        #region Add-On

       
        public void GenerateCustomerCode(long customerId)
        {
            var createCustCode = CustomerUnitOfWork.Customers.CreateCustCode(customerId);
        }
        public string GetShortCode(string surName)
        {
            string partName = surName.Substring(0, 3);
          
            var lastId = 0;

            using (var context = new TheCoreBankingCustomerContext())
            {
                  lastId = context.TblCustomer.Max(p => p.Customerid);

            }

      
            int lid2 = lastId + 1;
            string shortcode = partName + Convert.ToSingle(lid2);

            return shortcode.ToString();
        }
        #endregion

        private struct StateLGAs {
            public string ID, State, LGA;
        }

        private struct SectorIndustries
        {
            public string Industryid, Sectorid, Name;
        }

        private struct KYCItems
        {
            public string ID, AccountType, DisplayOrder, Item;
            public bool Mandatory;
        }

    }
}