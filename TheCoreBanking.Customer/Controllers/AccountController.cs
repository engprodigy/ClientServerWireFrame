using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Enums;
using TheCoreBanking.Customer.Data.Helpers;
using TheCoreBanking.Customer.Data.Models;
using TheCoreBanking.Customer.ViewModel;
using TheCoreBanking.Customer.ViewModels;


namespace TheCoreBanking.Customer.Controllers
{
    public class AccountController : Controller
    {
        private ICustomerUnitOfWork CustomerUnitOfWork { get; }
        public AccountController(ICustomerUnitOfWork uow)
        {
            CustomerUnitOfWork = uow;
        }

        private readonly TheCoreBankingCustomerContext _context = new TheCoreBankingCustomerContext();
        private readonly TheCoreBankingCustomerContext _context2 = new TheCoreBankingCustomerContext();
        private readonly TheCoreBankingFileContext _contextF = new TheCoreBankingFileContext();

        // TheCoreBankingCustomerContext

#if DEBUG
        //[Authorize()]
#else
            [Authorize()]
            [AllowAnonymous]
#endif
        public IActionResult Index()
        {
            return View();
        }

#if DEBUG
        //[Authorize()]
#else
            [Authorize()]
            [AllowAnonymous]
#endif
        public IActionResult Freeze()
        {
            return View();
        }

#if DEBUG
        //[Authorize()]
#else
            [Authorize()]
            [AllowAnonymous]
#endif
        public IActionResult PostStatus()
        {
            return View();
        }
#if DEBUG
        //[Authorize()]
#else
            [Authorize()]
            [AllowAnonymous]
#endif
        public IActionResult Maintenance()
        {
            return View();
        }

        #region Fetch

        public JsonResult LoadAccountReferees(int id)
        {
            var result = CustomerUnitOfWork.AccountReferees
                .GetByAccountId(id);
            return Json(result);
        }

        public JsonResult LoadAccountRefereeMaintenanceForApproval()
        {
            var result = CustomerUnitOfWork.AccountReferees
                .GetAll().Where(a => a.Isapproved == false && a.Isdeleted == true);
            return Json(result);
        }

        public JsonResult LoadAccountMandates(int id)
        {
            var result = CustomerUnitOfWork.Mandates
                .GetByAccountId(id);
            return Json(result);
        }


       // [HttpGet]
        public JsonResult LoadAccounts()
        {
            var result = CustomerUnitOfWork.Accounts.GetDetailed().OrderByDescending(c => c.Customerid).Take(10);

            var productList = CustomerUnitOfWork.Product.GetAll();//  .OrderByDescending(p => p.Productid);

            var productListCount = CustomerUnitOfWork.Product.GetAll().OrderByDescending(p => p.Productid).Count();

            Dictionary<string, string> productDictionary = new Dictionary<string, string>();

            // var counter = 0;

            foreach (var item in productList)
            {
              //products[Int32.Parse(item.Productid)] = item.Productname;
                productDictionary.Add(item.Productid, item.Productname);

            }


            CasaAccountViewModelPostStatus casaAccountViewModelPostStatus = new CasaAccountViewModelPostStatus();

            var list = new List<CasaAccountViewModelPostStatus>();
           // var result = CustomerUnitOfWork.CardTypes.GetActive();
            foreach (var item in result)
            {
                var booleanValue = true;
                try { 
                booleanValue = CustomerUnitOfWork.AccountFreeze.GetAll().Where(i => i.AccountNumber == item.Accountnumber).
                  FirstOrDefault().IsApproved;
                }
                catch
                {
                    booleanValue = true;
                }
                list.Add(new CasaAccountViewModelPostStatus
                {
                  
                   Casaaccountid = item.Casaaccountid,
                   Accountnumber  = item.Accountnumber,
                   Accountname   = item.Accountname,
                   Customerid   = item.Customerid,
                   ProductName = productDictionary[item.Productid.ToString()],
                   Productid = item.Productid,
                   Postnostatusid = item.Postnostatusid,
                   Approvalstatusid = booleanValue ? 1 : 0
                });
            }





            return Json(list);

        }


        
        public JsonResult LoadAccountsForIndexView()
        {
            var result = CustomerUnitOfWork.Accounts.GetDetailed();
            return Json(result);
        }


        [HttpPost]
        public JsonResult GetProductCasaAccountId(string casaName)
        {
            var result = CustomerUnitOfWork.Accounts.GetDetailed().Where(c => c.Accountname == casaName).FirstOrDefault().Casaaccountid;
            return Json(result);

        }
        public JsonResult LoadFrozenAccounts()
        {
            //var result = CustomerUnitOfWork.AccountFreeze.GetAll().Where(k => k.IsReversed == false && k.IsApproved == false).OrderByDescending(c => c.Id).Take(10);
            var result = CustomerUnitOfWork.AccountFreeze.GetAll().Where(k => k.IsReversed == false && k.IsApproved == false).OrderByDescending(c => c.Id);
            return Json(result);

        }

        public JsonResult LoadFrozenAccountsForCustomerModule()
        {
            var result = CustomerUnitOfWork.AccountFreeze.GetAll().Where(k => k.IsReversed == false ).OrderByDescending(c => c.Id).Take(10);
           
            var resultlist2 = CustomerUnitOfWork.AccountFreeze.GetAll().Where(k => k.IsReversed == true && k.IsApproved == false).OrderByDescending(c => c.Id).Take(10);

            List<TblAccountfreeze> tblAccountfreezeView = new List<TblAccountfreeze>();

            foreach (var debitLeg in resultlist2)
            {
                
                //var tblAccountfreeze = new TblAccountfreeze();

                debitLeg.IsApproved = true;

                tblAccountfreezeView.Add(debitLeg);
            }

                var combined = result.Concat(tblAccountfreezeView);

            return Json(combined);

        }

        public JsonResult LoadFreezeReversalTransactions()
        {
            var result = CustomerUnitOfWork.AccountFreeze.GetAll().Where(k => k.IsReversed == true && k.IsApproved == false).OrderByDescending(c => c.Id);
            return Json(result);

        }


        public JsonResult LoadAccountsSelectedColumn()
        {
            var result = CustomerUnitOfWork.Accounts.GetDetailed().Where(o => o.Approvalstatusid == 0).ToList().Select(i => new
            {

                CasaAccountId = i.Casaaccountid,
                CustomerAccountname = i.Accountname,
                CustomerAccountnumber = i.Accountnumber,
                DateTimeCreated = i.Datetimecreated,
                CreatedBy = i.Createdby,
                Approved = i.Approvalstatusid,
               /*nc = i.Accountstatusid,
                Pnd = i.Accountstatusid,
                Balance = i.Ledgerbalance*/
            }); 


            return Json(result);

        }

        [HttpGet]
        public JsonResult LoadAccountsSelectedColumnPost(int cassaccountid, string Comment)
        {
            var logUser = User.Identity.Name;
            if (logUser == null)
            {
                logUser = "tayo.olawumi";
            }


            var CustomerAccount = CustomerUnitOfWork.Accounts.GetDetailed().Where(o => o.Approvalstatusid == 0
              && o.Casaaccountid == cassaccountid).SingleOrDefault();

            AccountVM accountVM = new AccountVM();

            accountVM.CasaAccountId = CustomerAccount.Casaaccountid;
            accountVM.CustomerAccountname = CustomerAccount.Accountname;
            accountVM.CustomerAccountnumber = CustomerAccount.Accountnumber;
            accountVM.CreatedBy = CustomerAccount.Createdby;
            accountVM.Approved = CustomerAccount.Approvalstatusid.Value;
            accountVM.DateTimeCreated = CustomerAccount.Datetimecreated.Value;

            CustomerAccount.Approvalstatusid = 1;

            //.Accounts.Add(CustomerAccount);
            //CustomerUnitOfWork.Commit();
            var dbContextTransaction = _context.Database.BeginTransaction();
            try
            {


                _context.TblCasa.Update(CustomerAccount);
                _context.SaveChanges();

               

                dbContextTransaction.Commit();



            }
            catch
            {
                dbContextTransaction.Rollback();
            }




            return Json(accountVM);

        }


        [HttpGet]
        public JsonResult ApproveFrozenAccountsTransaction(int id, string Comment)
        {
            var logUser = User.Identity.Name;
            if (logUser == null)
            {
                logUser = "tayo.olawumi";
            }


            var CustomerAccount = CustomerUnitOfWork.AccountFreeze.GetAll().Where(o => o.IsApproved == false
              && o.Id == id).SingleOrDefault();

            FreezeAccountVM freezeAccountVM = new FreezeAccountVM();

            freezeAccountVM.AccountName = CustomerAccount.AccountName;
            freezeAccountVM.AccountNumber = CustomerAccount.AccountNumber;
            freezeAccountVM.CreatedBy = CustomerAccount.ApprovedBy;
            //freezeAccountVM.Approved = CustomerAccount.IsApproved;
            freezeAccountVM.DateTimeCreated = CustomerAccount.StartDate.Value;

            CustomerAccount.IsApproved = true;

            //.Accounts.Add(CustomerAccount);
            //CustomerUnitOfWork.Commit();
            var dbContextTransaction = _context.Database.BeginTransaction();
            try
            {


                _context.TblAccountfreeze.Update(CustomerAccount);
                _context.SaveChanges();



                dbContextTransaction.Commit();



            }
            catch
            {
                dbContextTransaction.Rollback();
            }




            return Json(freezeAccountVM);

        }


        [HttpGet]
        public JsonResult ApproveFreezeReversalTransactions(int id, string Comment)
        {
            var logUser = User.Identity.Name;
            if (logUser == null)
            {
                logUser = "tayo.olawumi";
            }


            var CustomerAccount = CustomerUnitOfWork.AccountFreeze.GetAll().Where(o => o.IsApproved == false
              && o.Id == id).SingleOrDefault();

            FreezeAccountVM freezeAccountVM = new FreezeAccountVM();

            freezeAccountVM.AccountName = CustomerAccount.AccountName;
            freezeAccountVM.AccountNumber = CustomerAccount.AccountNumber;
            freezeAccountVM.CreatedBy = CustomerAccount.ApprovedBy;
            //freezeAccountVM.Approved = CustomerAccount.IsApproved;
            freezeAccountVM.DateTimeCreated = CustomerAccount.StartDate.Value;

            CustomerAccount.IsApproved = true;

            //.Accounts.Add(CustomerAccount);
            //CustomerUnitOfWork.Commit();
            var dbContextTransaction = _context.Database.BeginTransaction();
            try
            {


                _context.TblAccountfreeze.Update(CustomerAccount);
                _context.SaveChanges();



                dbContextTransaction.Commit();



            }
            catch
            {
                dbContextTransaction.Rollback();
            }




            return Json(freezeAccountVM);

        }
        public JsonResult LoadAccountCardTypes()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.CardTypes.GetActive();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Cardname
                });
            }
            return Json(list);
        }

        public JsonResult LoadAlertMedia()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.AlertMedia.GetActive();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Alerttype
                });
            }
            return Json(list);
        }

        public JsonResult LoadBankingServices()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.BankingServices.GetActive();
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

        public JsonResult LoadAccountPostStatuses()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.AccountPostStatuses.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Postnostatusid.ToString(),
                    Text = item.Postnostatusname
                });
            }
            return Json(list);
        }

        public JsonResult LoadAccountPostStatusesForDataTableFormatter()
        {
           
            var result = CustomerUnitOfWork.AccountPostStatuses.GetAll();
           
            return Json(result);
        }

        public JsonResult LoadStatementFrequencies()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.StatementFrequencies.GetActive();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Frequency
                });
            }
            return Json(list);
        }

        public JsonResult LoadStatementMedia()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.StatementMedia.GetActive();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Statementmedium
                });
            }
            return Json(list);
        }

        public JsonResult LoadDepartments()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.Departments.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Department
                });
            }
            return Json(list);
        }

        public JsonResult LoadFreezeType()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.Freezetype.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.FreezeType
                });
            }
            return Json(list);
        }

        public JsonResult LoadFreezeReason()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.Reasontype.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.Reason
                });
            }
            return Json(list);
        }

        public JsonResult LoadFreezeDateType()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.FreezeDatetype.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Id.ToString(),
                    Text = item.DateType
                });
            }
            return Json(list);
        }





        [HttpGet]
        public JsonResult LoadStaffs() {
            var list = new List<SelectTwoContent>();
            string Uri = ApiConstants.BaseApiUrl + ApiConstants.UserEndpoint;
            var Staffs = CustomerUnitOfWork.API.GetAsync(Uri).Result;
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            IEnumerable<StaffInfoVM> result =
                JsonConvert.DeserializeObject<IEnumerable<StaffInfoVM>>(Staffs, settings);
            foreach (var item in result)
            {
                list.Add(
                    new SelectTwoContent
                    {
                        Id = item.Id,
                        Text = item.StaffName
                    }
                );
            }
            return Json(list);
        }

        [HttpGet]
        public JsonResult LoadProducts()
        {

            string Uri = null;

#if DEBUG
           
            if ((int)ApiEndPointEnum.APIENDPOINT == 1)
            { 

                Uri = ApiConstants.BaseApiUrl + ApiConstants.ProductEndpoint;

            }
            else {
               
                Uri = ApiConstants.BaseApiUrlDev + ApiConstants.ProductEndpointDev;

            }



#else
             Uri = ApiConstants.BaseApiUrl + ApiConstants.ProductEndpoint;

#endif

            var Products = CustomerUnitOfWork.API.GetAsync(Uri).Result;
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            IEnumerable<ProductVM> result =
                JsonConvert.DeserializeObject<IEnumerable<ProductVM>>(Products, settings);
            return Json(result);
        }


        [HttpGet]
        public JsonResult LoadFeeList()
        {


            string Uri = null;

#if DEBUG
           
            if ((int)ApiEndPointEnum.APIENDPOINT == 1)
            {

                Uri = ApiConstants.BaseApiUrl + ApiConstants.ProductFeeListEndpoint;

            }
            else
            {

                Uri = ApiConstants.BaseApiUrlDev + ApiConstants.ProductFeeListEndpointDev;

            }



#else
            Uri = ApiConstants.BaseApiUrl + ApiConstants.ProductFeeListEndpoint;

#endif

            var Products = CustomerUnitOfWork.API.GetAsync(Uri).Result;
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            IEnumerable<ProductFeeVM> result =
                JsonConvert.DeserializeObject<IEnumerable<ProductFeeVM>>(Products, settings);
            return Json(result);
        }



        [HttpGet]
        public JsonResult GetFeeName(string productName, string casaAccountId)
        {


            string Uri = null;

#if DEBUG

            if ((int)ApiEndPointEnum.APIENDPOINT == 1)
            {

                Uri = ApiConstants.BaseApiUrl + ApiConstants.ProductFeeLinkToAccountEndpoint + "?productName=" + productName;

            }
            else
            {

                Uri = ApiConstants.BaseApiUrlDev + ApiConstants.ProductFeeLinkToAccountEndpointDev + "?productName=" + productName;

            }



#else
             Uri = ApiConstants.BaseApiUrl + ApiConstants.ProductFeeLinkToAccountEndpoint + "?productName=" + productName;

#endif
            var Products = CustomerUnitOfWork.API.GetAsync(Uri).Result;
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            IEnumerable<FeeProductGroupList> result =
                JsonConvert.DeserializeObject<IEnumerable<FeeProductGroupList>>(Products, settings);
            return Json(result);
        }

        [HttpGet]
        public JsonResult GetFeeExtraName(string productName, string casaAccountId)
        {
            
    

            string Uri = null;

#if DEBUG

            if ((int)ApiEndPointEnum.APIENDPOINT == 1)
            {

                 Uri = ApiConstants.BaseApiUrl + ApiConstants.ProductFeeLinkToAccountExtraEndpoint + "?productName=" + productName + "&casaAccountId=" + casaAccountId;

            }
            else
            {

                Uri = ApiConstants.BaseApiUrlDev + ApiConstants.ProductFeeLinkToAccountExtraEndpointDev + "?productName=" + productName + "&casaAccountId=" + casaAccountId;

            }



#else
             Uri = ApiConstants.BaseApiUrl + ApiConstants.ProductFeeLinkToAccountExtraEndpoint + "?productName=" + productName + "&casaAccountId=" + casaAccountId;

#endif

            var Products = CustomerUnitOfWork.API.GetAsync(Uri).Result;
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            IEnumerable<FeeProductGroupList> result =
                JsonConvert.DeserializeObject<IEnumerable<FeeProductGroupList>>(Products, settings);
            return Json(result);
        }

        [HttpGet]
        public JsonResult ListCurrencies()
        {
            var list = new List<SelectTwoContent>();
            string Uri = ApiConstants.BaseApiUrl + ApiConstants.CurrencyEndpoint;
            var Currencies = CustomerUnitOfWork.API.GetAsync(Uri).Result;
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            IEnumerable<CurrencyVM> result =
                JsonConvert.DeserializeObject<IEnumerable<CurrencyVM>>(Currencies, settings);
            foreach (var item in result)
            {
                list.Add(
                    new SelectTwoContent
                    {
                        Id = item.CurrCode.ToString(),
                        Text = item.CurrName
                    }
                );
            }
            return Json(list);
        }

        [HttpGet]
        public JsonResult ConfirmFreezeStatus(string id)
        {

            var result = CustomerUnitOfWork.AccountFreeze.GetAll().Where(i => i.AccountNumber == id && i.IsReversed == false).Count();

            if(result == 1)
            {

                return Json(true);

            }
            else
            {
                return Json(false);
            }

           
        }

        [HttpGet]
        public JsonResult ConfirmFreezeReversalStatus(string id)
        {

            var result = CustomerUnitOfWork.AccountFreeze.GetAll().Where(i => i.AccountNumber.Contains(id) && i.IsReversed == true).Count();

            if (result == 1)
            {

                return Json(true);

            }
            else
            {
                return Json(false);
            }


        }

        [HttpGet]
        public JsonResult FreezeAccountReversal(string id)
        {

            
            var count = CustomerUnitOfWork.AccountFreeze.GetAll().Where(i => i.AccountNumber.Contains(id) && i.IsApproved == true).Count();

           
            if(count == 1)

             {

                var result = CustomerUnitOfWork.AccountFreeze.GetAll().Where(i => i.AccountNumber.Contains(id) && i.IsApproved == true).FirstOrDefault();
                result.IsReversed = true;
                result.IsApproved = false;

                // var customerAccountDetail = CustomerUnitOfWork.Accounts.GetAll().Where(i => i.Accountnumber == id).FirstOrDefault();

                var customerAccountDetail = CustomerUnitOfWork.Accounts.GetAll().Where(i => i.Accountnumber.Contains(id)).FirstOrDefault();

                customerAccountDetail.Postnostatusid = 1;

                var dbContextTransaction = _context.Database.BeginTransaction();

                try
                {

                    _context.TblAccountfreeze.Update(result);

                    _context.SaveChanges();

                    _context.TblCasa.Update(customerAccountDetail);

                    _context.SaveChanges();

                    dbContextTransaction.Commit();

                }
                catch
                {
                    dbContextTransaction.Rollback();
                }






                return Json(true);
            }
            else
            {

                return Json(false);

            }

            


        }

        public JsonResult LoadAccountMandate(string id)
        {

            try {
            
            var mandateId = CustomerUnitOfWork.Mandates.GetAll().Where(p => p.Casaaccountid == Int32.Parse(id)).FirstOrDefault().Mandateid;

            var mandateImages = _contextF.TblMandateimages.Where(q => q.Mandateid == mandateId && q.Isdeleted == false).ToList();

            return Json(mandateImages);

            } catch 
            {

                return Json(false);
            }




            
        }

        public JsonResult LoadAccountMandateMaintenance(string id)
        {
            // var mandatesData = CustomerUnitOfWork.Mandates.GetAll().Where(p => p.Casaaccountid == Int32.Parse(id));

            try { 

            var MandatesDetails = (from a in _context.TblMandate
                       join c in _context.TblCasa on a.Casaaccountid equals c.Casaaccountid     
                       where a.Casaaccountid == Int32.Parse(id) && a.Isdeleted == false 
                       select new { MandateID = a.Mandateid, Signatorysurname = a.Signatorysurname, Signatoryothername = a.Signatoryothername,
                           Signatoryfirstname = a.Signatoryfirstname, Casaaccountnumber = c.Accountnumber
                       }).ToArray();

               

                var query = (from b in _contextF.TblMandateimages
                         join a in MandatesDetails on b.Mandateid equals a.MandateID
                         where b.Isdeleted == false
                         select new
                         {
                             MandateId = a.MandateID,
                             Accountnumber = a.Casaaccountnumber,
                             Signatorysurname = a.Signatorysurname,
                             Signatoryothername = a.Signatoryothername,
                             Signatoryfirstname = a.Signatoryfirstname,
                             Isapproved = b.Isapproved,
                             Isdisapproved = b.Isdisapproved,
                             Description = b.Description,
                             Approvalstatus = b.Approvalstatus,
                             Mime = b.Mime,
                             Byte = b.Byte,
                             FileId = b.Fileid
                         });
           

            return Json(query);
            }
            catch
            {
                return Json(false);
            }
        }


        public JsonResult LoadAccountMandateMaintenanceForApproval()
        {
            try
            {

                var MandatesDetails = (from a in _context.TblMandate
                                       join c in _context.TblCasa on a.Casaaccountid equals c.Casaaccountid
                                       
                                       select new
                                       {
                                           MandateID = a.Mandateid,
                                           Signatorysurname = a.Signatorysurname,
                                           Signatoryothername = a.Signatoryothername,
                                           Signatoryfirstname = a.Signatoryfirstname,
                                           Casaaccountnumber = c.Accountnumber
                                       }).ToArray();



                var query = (from b in _contextF.TblMandateimages
                             join a in MandatesDetails on b.Mandateid equals a.MandateID
                             where b.Isdeleted == true
                             select new
                             {
                                 MandateId = a.MandateID,
                                 Accountnumber = a.Casaaccountnumber,
                                 Signatorysurname = a.Signatorysurname,
                                 Signatoryothername = a.Signatoryothername,
                                 Signatoryfirstname = a.Signatoryfirstname,
                                 Isapproved = b.Isapproved,
                                 Isdisapproved = b.Isdisapproved,
                                 Description = b.Description,
                                 Approvalstatus = b.Approvalstatus,
                                 Mime = b.Mime,
                                 Byte = b.Byte,
                                 FileId = b.Fileid,
                                 CopyFileId = b.Copyfileid
                             });


                return Json(query);
            }
            catch
            {
                return Json(false);
            }
        }

        #endregion

        #region Create

        [HttpPost]

        public JsonResult AddAccount([FromBody]AddAccountVM accountinfo)
        {
            accountinfo.Account.Datetimecreated = DateTime.Now;
            accountinfo.Account.Postnostatusid = (int) AccountPostingStatus.NOENTRY;
            accountinfo.Account.Accountnumber = GetRandNo(11);
            accountinfo.Account.Accountstatusid = (int) AccountStatusEnum.UNAPPROVED;
            accountinfo.Account.TblCustomeraccountservice
                .Add(accountinfo.AccountService);

            if (accountinfo.BankingServices.Count > 0)
            {
                foreach (var item in accountinfo.BankingServices)
                {
                    accountinfo.AccountService.TblCustomeraccountbankingservice.Add(item);
                }
            }

            if (accountinfo.AlertMediums.Count > 0)
            {
                foreach (var item in accountinfo.AlertMediums)
                {
                    accountinfo.AccountService.TblCustomeraccountalertmedium.Add(item);
                }
            }

            if (accountinfo.StatementMediums.Count > 0)
            {
                foreach (var item in accountinfo.StatementMediums)
                {
                    accountinfo.AccountService.TblCustomeraccountstmntmedium.Add(item);
                }
            }

            CustomerUnitOfWork.Accounts.Add(accountinfo.Account);
            CustomerUnitOfWork.Commit();

            return Json(accountinfo.Account.Casaaccountid);
        }

        public JsonResult AddAccountSignatory(int id, AddSignatoryVM upload, bool sendall)
        {
            upload.Data.Casaaccountid = id;
            CustomerUnitOfWork.Mandates.Add(upload.Data);
            CustomerUnitOfWork.Commit();

            // images upload
            if (upload.Passport != null || 
                upload.Signature != null || 
                upload.Thumbprint != null)
            {
                using (var db = new TheCoreBankingFileContext())
                {
                    if (upload.Passport != null)
                    {
                        TblMandateimages mandate = new TblMandateimages
                        {
                            Mandateid = upload.Data.Mandateid,
                            Description = "Passport",
                            Mime = upload.Passport.ContentType,
                            Isdeleted = false,
                        };
                        using (var stream = new MemoryStream())
                        {
                            upload.Passport.CopyTo(stream);
                            mandate.Byte = stream.ToArray();
                        }
                        db.TblMandateimages.Add(mandate);
                    }
                    if (upload.Signature != null)
                    {
                        TblMandateimages mandate = new TblMandateimages
                        {
                            Mandateid = upload.Data.Mandateid,
                            Description = "Signature",
                            Mime = upload.Signature.ContentType,
                            Isdeleted = false,
                        };
                        using (var stream = new MemoryStream())
                        {
                            upload.Signature.CopyTo(stream);
                            mandate.Byte = stream.ToArray();
                        }
                        db.TblMandateimages.Add(mandate);
                    }
                    if (upload.Thumbprint != null)
                    {
                        TblMandateimages mandate = new TblMandateimages
                        {
                            Mandateid = upload.Data.Mandateid,
                            Description = "Thumbprint",
                            Mime = upload.Thumbprint.ContentType,
                            Isdeleted = false,
                        };
                        using (var stream = new MemoryStream())
                        {
                            upload.Thumbprint.CopyTo(stream);
                            mandate.Byte = stream.ToArray();
                        }
                        db.TblMandateimages.Add(mandate);
                    }
                    db.SaveChanges();
                }      
            }

            if (sendall) {
                var mandates = CustomerUnitOfWork.Mandates
               .GetByAccountId(id);
                return Json(mandates);
            }
            return Json(true);
        }

        public JsonResult AddMandateUpdate(string id, AddMandateVM upload, int fileid, int mandateid)
        {

           
           if (upload.Mandate != null )
               
            {
                using (var db = new TheCoreBankingFileContext())
                {
                    if (upload.Mandate != null)
                    {
                       
                        var mandateImageForStatusChange = db.TblMandateimages.Where(f => f.Fileid == fileid).FirstOrDefault();
                        mandateImageForStatusChange.Approvalstatus = "New Copy Awaiting Approval";
                        db.Update(mandateImageForStatusChange);
                        db.SaveChanges();
                        
                    }
                    
                    
                    
                }
            }

            var dbContextTransaction = _contextF.Database.BeginTransaction();

            try
            {
                if (upload.Mandate != null)
                {
                    TblMandateimages mandate = new TblMandateimages
                    {
                        
                        Mandateid = upload.Data.Mandateid,
                        Description = id,
                        Mime = upload.Mandate.ContentType,
                        Isdeleted = true,
                        Isapproved = false,
                        Isdisapproved = false,
                        Approvalstatus = "Pending",
                        Copyfileid = fileid
                    };
                    using (var stream = new MemoryStream())
                    {
                        upload.Mandate.CopyTo(stream);
                        mandate.Byte = stream.ToArray();
                    }
                    //db.TblMandateimages.Update(mandate);
                    //db.SaveChanges();
                    //return Json(mandate);
                    _contextF.TblMandateimages.Add(mandate);
                    _contextF.SaveChanges();
                    dbContextTransaction.Commit();
                    return Json(mandate);
                }
               

                
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                dbContextTransaction.Rollback();
                return Json(false);
            }


            return Json(false);


            //if (sendall)
            //{
            //    var mandates = CustomerUnitOfWork.Mandates
            //   .GetByAccountId(id);
            //    return Json(mandates);
            //}



        }

            public JsonResult AddAccountReferee(int id, AddRefereeVM upload, bool sendall)
        {

            int? newUploadRefereeId = null;
           // using (var db2 = new TheCoreBankingCustomerContext())
           // { 
            upload.Data.Casaaccountid = id;
            upload.Data.Isdeleted = false;
            upload.Data.Isapproved = false;
            upload.Data.Approvalstatus = "Pending";
            upload.Data.Isnewlycreated = true;
            //  db2.TblAccountreferee.Add(upload.Data);
            //  db2.SaveChanges();


            //  }
            CustomerUnitOfWork.AccountReferees.Add(upload.Data);
            CustomerUnitOfWork.Commit();
            newUploadRefereeId = upload.Data.Refereeid;

            var dbContextTransaction2 = _context2.Database.BeginTransaction();
            try
            {
                TblAccountreferee accountreferee = new TblAccountreferee
                {

                    Casaaccountid = upload.Data.Casaaccountid,
                    Fullname = upload.Data.Fullname,
                    Address = upload.Data.Address,
                    Phone = upload.Data.Phone,
                    Accountname = upload.Data.Accountname,
                    Accountno = upload.Data.Accountno,
                    Relationship = upload.Data.Relationship,
                    Bankid = upload.Data.Bankid,
                    Datecreated = upload.Data.Datecreated,
                    Bankaddress = upload.Data.Bankaddress,
                    Isdeleted = true,
                    Isapproved = false,
                    Isdisapproved = false,
                    Approvalstatus = "Pending",
                    Copyfileid = newUploadRefereeId.Value,
                    Isnewlycreated = false
                };


                _context2.TblAccountreferee.Add(accountreferee);
                _context2.SaveChanges();
                dbContextTransaction2.Commit();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                dbContextTransaction2.Rollback();
                // return Json(false);
            }

            using (var db = new TheCoreBankingFileContext())
            using (var stream = new MemoryStream())
            {
                upload.Document.CopyTo(stream);
                TblRefereedocuments refereedocument = new TblRefereedocuments
                {
                    Refereeid = upload.Data.Refereeid,
                    Mime = upload.Document.ContentType,
                    Isdeleted = false,
                    Filedata = stream.ToArray()
                };
                db.TblRefereedocuments.Add(refereedocument);
                db.SaveChanges();
            }

            if (sendall) {
                var referees = CustomerUnitOfWork.AccountReferees
               .GetByAccountId(id);
                return Json(referees);
            }
            return Json(true);
        }

        public JsonResult UpdateAccountReferee(int id, AddRefereeVM upload, bool sendall)
        {
            // upload.Data.Casaaccountid = id;
            var storedRefereeData = CustomerUnitOfWork.AccountReferees.GetAll().Where(r => r.Refereeid == upload.Data.Refereeid).FirstOrDefault();
            storedRefereeData.Isdeleted = false;
            storedRefereeData.Isapproved = false;
            storedRefereeData.Isnewlycreated = false;
            storedRefereeData.Approvalstatus = "New Copy Sent for Approval";
            //CustomerUnitOfWork.AccountReferees.Update(upload.Data);
            //CustomerUnitOfWork.Commit();

            //if (upload.Data.Isnewlycreated == false)
            //{
            var dbContextTransaction2 = _context2.Database.BeginTransaction();
            try
            {
                _context2.TblAccountreferee.Update(storedRefereeData);
                _context2.SaveChanges();
                dbContextTransaction2.Commit();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                dbContextTransaction2.Rollback();
                // return Json(false);
            }

            var dbContextTransaction = _context.Database.BeginTransaction();

                try
                {
                    if (upload.Data != null)
                    {
                        TblAccountreferee accountreferee = new TblAccountreferee
                        {

                            Casaaccountid = upload.Data.Casaaccountid,
                            Fullname = upload.Data.Fullname,
                            Address = upload.Data.Address,
                            Phone = upload.Data.Phone,
                            Accountname = upload.Data.Accountname,
                            Accountno = upload.Data.Accountno,
                            Relationship = upload.Data.Relationship,
                            Bankid = upload.Data.Bankid,
                            Datecreated = upload.Data.Datecreated,
                            Bankaddress = upload.Data.Bankaddress,
                            Isdeleted = true,
                            Isapproved = false,
                            Isdisapproved = false,
                            Approvalstatus = "Pending",
                            Copyfileid = upload.Data.Refereeid,
                            Isnewlycreated = false
                        };

                        //db.TblMandateimages.Update(mandate);
                        //db.SaveChanges();
                        //return Json(mandate);
                        _context.TblAccountreferee.Add(accountreferee);
                        _context.SaveChanges();
                        dbContextTransaction.Commit();
                       // return Json(accountreferee);
                    }



                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                    dbContextTransaction.Rollback();
                   // return Json(false);
                }



                

            //}
            //else
            //{

            //    upload.Data.Isdeleted = false;
            //    upload.Data.Isapproved = false;
            //    upload.Data.Isnewlycreated = true;
            //    upload.Data.Approvalstatus = "New Copy Sent for Approval";
            //    CustomerUnitOfWork.AccountReferees.Update(upload.Data);
            //    CustomerUnitOfWork.Commit();

            //}


            //int? tableId = null;
            //using (var db = new TheCoreBankingFileContext())
            //{
            //    tableId = db.TblRefereedocuments.Where(i => i.Refereeid == upload.Data.Refereeid).FirstOrDefault().Id ;
            //}

            //using (var db = new TheCoreBankingFileContext())

            // using (var stream = new MemoryStream())
            //{
            //    upload.Document.CopyTo(stream);
            //    TblRefereedocuments refereedocument = new TblRefereedocuments
            //    {
            //        Id = tableId.Value,
            //        Refereeid = upload.Data.Refereeid,
            //        Mime = upload.Document.ContentType,
            //        Isdeleted = false,
            //        Filedata = stream.ToArray()
            //    };
            //    db.TblRefereedocuments.Update(refereedocument);
            //    db.SaveChanges();
            //}

            if (sendall)
            {
                var referees = CustomerUnitOfWork.AccountReferees
               .GetByAccountId(id);
                return Json(referees);
            }
            return Json(true);
        }


        public JsonResult FreezeAccount([FromBody]AddAccountVM accountinfo)
        {

            CustomerUnitOfWork.FreezeDatetype.GetAll();

            return Json(true);

        }





        [HttpPost]
        public JsonResult AddDocumentUpload(int id, AccompanyDocumentVM upload, bool sendall)
        {
            //List<TblKycdocuments> files = null;
            using (var db = new TheCoreBankingFileContext())
            using (var stream = new MemoryStream())
            {
                upload.Document.CopyTo(stream);
                TblKycdocuments kycdocument = new TblKycdocuments
                {
                    Filedata = stream.ToArray(),
                    //Customerid = Int32.Parse(upload.Title),
                    Customerid = id,
                    Title = upload.Title,
                    Mime = upload.Document.ContentType,
                    Isdeleted = false
                };
                db.TblKycdocuments.Add(kycdocument);
                db.SaveChanges();
                /* if (sendall)
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
                 }*/
            }
            // if (sendall) { return Json(files); }
            return Json(true);
        }

        [HttpPost]
        public JsonResult FreezeAccount(TblAccountfreeze freeze)
        {


            var count = CustomerUnitOfWork.AccountFreeze.GetAll().Where(i => i.AccountNumber == freeze.AccountNumber && i.IsReversed == true).Count();

            if (count == 1)
            {

                var result = CustomerUnitOfWork.AccountFreeze.GetAll().Where(i => i.AccountNumber == freeze.AccountNumber && i.IsReversed == true).FirstOrDefault();


                var dbContextTransaction = _context.Database.BeginTransaction();

                try
                {

                    _context.TblAccountfreeze.Remove(result);
                    _context.SaveChanges();

                    dbContextTransaction.Commit();

                }
                catch
                {
                    dbContextTransaction.Rollback();
                }


            }



            var now = DateTime.Now;
            
            freeze.TransactionTime = now.ToShortTimeString();
            freeze.FreezeCode = "1";

            //using (var db = new TheCoreBankingFileContext())

            if (freeze.FreezeTypeId == 13)
                {
                    // var result = FreezeUnitOfWork.Casa.GetAll().Where(i => i.ProductAcctNo == freeze.AccountNumber).FirstOrDefault();
                    var result = CustomerUnitOfWork.Accounts.GetAll().Where(i => i.Accountnumber == freeze.AccountNumber).FirstOrDefault();
                    /*result.Pnd = true;
                    result.Pnc = false;*/
                    result.Postnostatusid = 3;
                    freeze.AccountName = result.Accountname;
                    //result.Balance = freeze.Balance;
                    decimal? formattedAvailablebalance = result.Availablebalance;
                    freeze.Balance = formattedAvailablebalance;
                    CustomerUnitOfWork.Accounts.Update(result);
                    freeze.IsCreditOnlyFreeze = false;
                    freeze.IsDebitOnlyFreeze = true;
                    freeze.IsFreeze = true;
                    freeze.IsApproved = false;
                    freeze.IsTotalFreeze = false;
                    freeze.IsPartialFreeze = false;
                    freeze.IsReversed = false;
                    freeze.Disapproved = false;
                    //freeze.BranchId = result.BranchId;
                    freeze.BranchId = result.Branchid.ToString();

                }
                else if (freeze.FreezeTypeId == 4)
                {
                    //var result = FreezeUnitOfWork.Casa.GetAll().Where(i => i.ProductAcctNo == freeze.AccountNumber).FirstOrDefault();
                    var result = CustomerUnitOfWork.Accounts.GetAll().Where(i => i.Accountnumber == freeze.AccountNumber).FirstOrDefault();
                    /*result.Pnc = true;
                    result.Pnd = false;*/
                    result.Postnostatusid = 2;
                    freeze.AccountName = result.Accountname;
                    //result.Balance = freeze.Balance;
                    decimal? formattedAvailablebalance = result.Availablebalance;
                    freeze.Balance = formattedAvailablebalance;
                    CustomerUnitOfWork.Accounts.Update(result);
                    freeze.IsCreditOnlyFreeze = true;
                    freeze.IsDebitOnlyFreeze = false;
                    freeze.IsFreeze = true;
                    freeze.IsApproved = false;
                    freeze.IsTotalFreeze = false;
                    freeze.IsPartialFreeze = false;
                    freeze.IsReversed = false;
                    freeze.Disapproved = false;
                    //freeze.BranchId = result.BranchId;
                    freeze.BranchId = result.Branchid.ToString();
                }
                else if (freeze.FreezeTypeId == 1)
                {
                    //var result = FreezeUnitOfWork.Casa.GetAll().Where(i => i.ProductAcctNo == freeze.AccountNumber).FirstOrDefault();
                    var result = CustomerUnitOfWork.Accounts.GetAll().Where(i => i.Accountnumber == freeze.AccountNumber).FirstOrDefault();
                    /*result.Pnd = true;
                    result.Pnc = true;*/
                    result.Postnostatusid = 4;
                    freeze.AccountName = result.Accountname;
                    //result.Balance = freeze.Balance;
                    decimal? formattedAvailablebalance = result.Availablebalance;
                    freeze.Balance = formattedAvailablebalance;
                    CustomerUnitOfWork.Accounts.Update(result);
                    freeze.IsCreditOnlyFreeze = true;
                    freeze.IsDebitOnlyFreeze = true;
                    freeze.IsFreeze = true;
                    freeze.IsApproved = false;
                    freeze.IsTotalFreeze = true;
                    freeze.IsPartialFreeze = false;
                    freeze.IsReversed = false;
                    freeze.Disapproved = false;
                    //freeze.BranchId = result.BranchId;
                    freeze.BranchId = result.Branchid.ToString();
                }
                else if (freeze.FreezeTypeId == 2)
                {
                    //var result = FreezeUnitOfWork.Casa.GetAll().Where(i => i.ProductAcctNo == freeze.AccountNumber).FirstOrDefault();
                    var result = CustomerUnitOfWork.Accounts.GetAll().Where(i => i.Accountnumber == freeze.AccountNumber).FirstOrDefault();
                    /*result.Pnd = false;
                    result.Pnc = false;*/
                    result.Postnostatusid = 4;
                    freeze.AccountName = result.Accountname;
                    //result.Balance = freeze.Balance;
                    decimal? formattedAvailablebalance = result.Availablebalance;
                    freeze.Balance = formattedAvailablebalance;
                    CustomerUnitOfWork.Accounts.Update(result);

                    freeze.IsCreditOnlyFreeze = false;
                    freeze.IsDebitOnlyFreeze = false;
                    freeze.IsFreeze = true;
                    freeze.IsApproved = false;
                    freeze.IsTotalFreeze = false;
                    freeze.IsPartialFreeze = true;
                    freeze.IsReversed = false;
                    freeze.Disapproved = false;
                    //freeze.BranchId = result.BranchId;
                    freeze.BranchId = result.Branchid.ToString();
                }
                else if (freeze.FreezeTypeId == 3)
            {
                    //var result = FreezeUnitOfWork.Casa.GetAll().Where(i => i.ProductAcctNo == freeze.AccountNumber).FirstOrDefault();
                    var result = CustomerUnitOfWork.Accounts.GetAll().Where(i => i.Accountnumber == freeze.AccountNumber).FirstOrDefault();
                    /*result.Pnd = true;
                    result.Pnc = true;*/
                    result.Postnostatusid = 4;
                    freeze.AccountName = result.Accountname;
                    //result.Balance = freeze.Balance;
                    decimal? formattedAvailablebalance = result.Availablebalance;
                    freeze.Balance = formattedAvailablebalance;
                    CustomerUnitOfWork.Accounts.Update(result);

                    freeze.StartDate = DateTime.Now;
                    freeze.IsCreditOnlyFreeze = true;
                    freeze.IsDebitOnlyFreeze = true;
                    freeze.IsFreeze = true;
                    freeze.IsApproved = false;
                    freeze.IsTotalFreeze = false;
                    freeze.IsPartialFreeze = true;
                    freeze.IsReversed = false;
                    freeze.Disapproved = false;
                    //freeze.BranchId = result.BranchId;
                    freeze.BranchId = result.Branchid.ToString();

                }
            CustomerUnitOfWork.AccountFreeze.Add(freeze);
            CustomerUnitOfWork.Commit();

            return Json(true);

        }

        public JsonResult AddProductFeesList(int Id, int PdFeesId,int casaAccountId, string productId, string PdFeesName, bool PdRate)
        {

            // var feelist= setupUnitOfWork.FeesList.GetById(Id);

            TblBankingProductFeesListExtraMaintenance fees = new TblBankingProductFeesListExtraMaintenance();
            // fees.PdId = id;
            fees.PdId = int.Parse(productId);
            fees.Casaaccountid = casaAccountId;
            fees.PdFeesId = PdFeesId;
            fees.PdFeesName = PdFeesName;
            fees.PdRate = PdRate;

            
            var dbContextTransaction = _context.Database.BeginTransaction();

            try
            {

                _context.TblBankingProductFeesListExtraMaintenance.Add(fees);
                _context.SaveChanges();

                dbContextTransaction.Commit();

            }
            catch(Exception e)
            {
                Debug.WriteLine( e.ToString());
               dbContextTransaction.Rollback();
            }
            return Json(fees.Id);
        }
        #endregion

        #region Update

        public JsonResult UpdateAccount([FromBody]UpdateAccountVM accountinfo)
        {
            CustomerUnitOfWork.Accounts.Update(accountinfo.Account);
            CustomerUnitOfWork.AccountServices.Update(accountinfo.AccountService);
            
            // existing values
            var bankingServices = CustomerUnitOfWork
                .AccountBankingServices.GetByAccountServiceID(accountinfo.AccountService.Id);
            var alertMedia = CustomerUnitOfWork
                .AccountAlertMedia.GetByAccountServiceID(accountinfo.AccountService.Id);
            var statementMedia = CustomerUnitOfWork
                .AccountStatementMedia.GetByAccountServiceID(accountinfo.AccountService.Id);

            // array of values to be deleted
            List<TblCustomeraccountbankingservice> bankingServiceToDelete 
                = new List<TblCustomeraccountbankingservice>();
            List<TblCustomeraccountalertmedium> alertMediaToDelete 
                = new List<TblCustomeraccountalertmedium>();
            List<TblCustomeraccountstmntmedium> StatementMediaToDelete 
                = new List<TblCustomeraccountstmntmedium>();

            // banking services
            foreach (var existingItem in bankingServices)
            {
                if (!accountinfo.BankingServiceids.Contains(existingItem.Bankingserviceid))
                {
                    bankingServiceToDelete.Add(existingItem);
                } else {
                    accountinfo.BankingServiceids.Remove(existingItem.Bankingserviceid);
                }
                
            }
            // alert services
            foreach (var existingItem in alertMedia)
            {
                if (!accountinfo.AlertMediumids.Contains(existingItem.Alertmediumid))
                {
                    // isn't in new selection, delete from db
                    alertMediaToDelete.Add(existingItem);
                } else
                {
                    // already exists, remove from list
                    accountinfo.AlertMediumids.Remove(existingItem.Alertmediumid);
                }
            }
            // statement services
            foreach (var existingItem in statementMedia)
            {
                if (!accountinfo.StatementMediumids.Contains(existingItem.Statementmediumid))
                {
                    StatementMediaToDelete.Add(existingItem);
                } else {
                    accountinfo.StatementMediumids.Remove(existingItem.Statementmediumid);
                }
            }

            // delete removed items
            foreach (var item in bankingServiceToDelete)
            {
                CustomerUnitOfWork.AccountBankingServices.Delete(item);
            }
            foreach (var item in alertMediaToDelete)
            {
                CustomerUnitOfWork.AccountAlertMedia.Delete(item);
            }
            foreach (var item in StatementMediaToDelete)
            {
                CustomerUnitOfWork.AccountStatementMedia.Delete(item);
            }

            // add new items
            foreach(var item in accountinfo.BankingServiceids)
            {
                CustomerUnitOfWork.AccountBankingServices.Add(
                    new TblCustomeraccountbankingservice {
                        Bankingserviceid = item,
                        Customeraccountserviceid = accountinfo.AccountService.Id
                    }
                );
            }
            foreach (var item in accountinfo.StatementMediumids)
            {
                CustomerUnitOfWork.AccountStatementMedia.Add(
                    new TblCustomeraccountstmntmedium
                    {
                        Statementmediumid = item,
                        Customeraccountserviceid = accountinfo.AccountService.Id
                    }
                );
            }
            foreach (var item in accountinfo.AlertMediumids)
            {
                CustomerUnitOfWork.AccountAlertMedia.Add(
                    new TblCustomeraccountalertmedium {
                        Alertmediumid = item,
                        Customeraccountserviceid = accountinfo.AccountService.Id
                    }
                );
            }
            CustomerUnitOfWork.Commit();

            return Json(true);
        }


        public JsonResult UpdateAccountMandateApproval(int FileId, int MandateId, string Description, string Comment, int Copyfileid)
        {
            
            
            
            var db2 = new TheCoreBankingFileContext();
            var mandateDetailForDelete = db2.TblMandateimages.Where(f => f.Mandateid == MandateId && f.Isdeleted == false && f.Description 
             == Description && f.Fileid == Copyfileid).FirstOrDefault();
            db2.Remove(mandateDetailForDelete);
            db2.SaveChanges();
            

            var db = new TheCoreBankingFileContext();

            var mandateDetail =  db.TblMandateimages.Where(f => f.Fileid == FileId).FirstOrDefault();
            // db.SaveChanges();
            // return Json(mandate);

            mandateDetail.Isapproved = true;
            mandateDetail.Isdisapproved = false;
            mandateDetail.Isdeleted = false;
            mandateDetail.Approvalstatus = "Approved";


           
            var dbContextTransaction = _contextF.Database.BeginTransaction();

            try
            {

                _contextF.TblMandateimages.Update(mandateDetail);
                _contextF.SaveChanges();

                dbContextTransaction.Commit();

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                dbContextTransaction.Rollback();
            }

            return Json(true);

        }

        public JsonResult UpdateAccountRefereeApproval(int Refereeid, string Comment, int Copyfileid)
        {


            try { 
            var db2 = new TheCoreBankingCustomerContext();
            var refereeDetailForDelete = db2.TblAccountreferee.Where(f => f.Refereeid == Copyfileid).FirstOrDefault();
            db2.Remove(refereeDetailForDelete);
            db2.SaveChanges();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                
            }


            var refereeDetail = CustomerUnitOfWork.AccountReferees.GetById(Refereeid);
            refereeDetail.Isapproved = true;
            refereeDetail.Isdisapproved = false;
            refereeDetail.Isdeleted = false;
            refereeDetail.Isnewlycreated = false;
            refereeDetail.Approvalstatus = "Approved";
            //CustomerUnitOfWork.Commit();

            var dbContextTransaction = _context.Database.BeginTransaction();

            try
            {

                _context.TblAccountreferee.Update(refereeDetail);
                _context.SaveChanges();

                dbContextTransaction.Commit();

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                dbContextTransaction.Rollback();
            }

            return Json(true);

        }

        #endregion

        #region Delete

        public IActionResult DeleteAccountReferee(int id)
        {
            if (id <= 0) return BadRequest();
            var referee = CustomerUnitOfWork.AccountReferees
                .GetById(id);
            if (referee == null) return BadRequest();
            referee.Isdeleted = true;
            CustomerUnitOfWork.Commit();
            var result = CustomerUnitOfWork.AccountReferees
                .GetByAccountId(referee.Casaaccountid);
            return Json(result);
        }

        public IActionResult DeleteAccountMandate(int id)
        {
            if (id <= 0) return BadRequest();
            var mandate = CustomerUnitOfWork.Mandates
                .GetById(id);
            if (mandate == null) return BadRequest();
            mandate.Isdeleted = true;
            CustomerUnitOfWork.Commit();
            var result = CustomerUnitOfWork.Mandates
                .GetByAccountId(mandate.Casaaccountid);
            return Json(result);
        }

        public JsonResult DeleteProductFeesList(int PdFeesId, int Id, string productId, string PdFeesName, bool PdRate)
        {

            var feelist = _context.TblBankingProductFeesListExtraMaintenance.Where(p => p.Id == Id).FirstOrDefault();

            TblBankingProductFeesListExtraMaintenance fees = new TblBankingProductFeesListExtraMaintenance();
            fees.Id = feelist.Id;
            fees.Casaaccountid = feelist.Casaaccountid;
            fees.PdId = int.Parse(productId);
            fees.PdFeesId = feelist.PdFeesId;
            fees.PdFeesName = feelist.PdFeesName;
            fees.PdRate = feelist.PdRate;
            fees.AdditionStatus = feelist.AdditionStatus;
            fees.RateValue = feelist.RateValue;
            fees.FeeValue = feelist.FeeValue;


            var dbContextTransaction = _context2.Database.BeginTransaction();

            try
            {
                _context2.TblBankingProductFeesListExtraMaintenance.Remove(fees);
                _context2.SaveChanges();

                dbContextTransaction.Commit();

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                dbContextTransaction.Rollback();
            }
            return Json(fees.Id);
           
        }


        #endregion

        #region API

        [HttpGet]
        public JsonResult GetMandatesByAccNo(string id)
        {
            var result = CustomerUnitOfWork.Accounts.GetMandates(id);
            return Json(result);
        }

        [HttpGet]
        public JsonResult GetCasaProductGlByAccNo(string id)
        {
            var result = CustomerUnitOfWork.Accounts.GetProductDetails(id);
            
            int? productId = null;

            foreach (TblCasa s in result)
            {
                productId = s.Productid;
            }

            var resultNew = CustomerUnitOfWork.Product.GetPrinciplaBalanceGLById(productId);
            //return Json(result);
            int? principalglId = null;

            foreach (TblProduct s in resultNew)
            {
                principalglId = s.Principalbalancegl;
            }
            return Json(principalglId);
        }

        [HttpGet]
        public JsonResult GetCasaByAccountNo(string id)
        {
            var result = CustomerUnitOfWork.Accounts.GetDetailedByAccountNo(id);
            return Json(result);
        }

        [HttpGet]
        public JsonResult GetCustomerCasaBalance(string accountNumber)
        {
            var result = CustomerUnitOfWork.Accounts.GetProductDetails(accountNumber);

            decimal? accountBalance = null;

            foreach (var item in result)
            {
                accountBalance = item.Availablebalance;
            }
            return Json(accountBalance);
        }

        [HttpGet]
        public JsonResult GetCustomerCasaProductCode(string accountNumber)
        {
            var result = CustomerUnitOfWork.Accounts.GetProductDetails(accountNumber);

            int? productCode = null;

            foreach (var item in result)
            {
                productCode = item.Productid;
            }
            return Json(productCode);
        }

        [HttpGet]
        public JsonResult GetCasaCustomerCode(string accountNumber)
        {
            var result = CustomerUnitOfWork.Accounts.GetProductDetails(accountNumber);

            int? customerCode = null;

            foreach (var item in result)
            {
                customerCode = item.Customerid;
            }
            return Json(customerCode);
        }

        [HttpGet]
        public JsonResult LoadMandateFiles(int id)
        {
            List<TblMandateimages> files;

            using (var db = new TheCoreBankingFileContext())
            {
                files = db.TblMandateimages
                    .Where(m => m.Mandateid == id)
                    .Where(m => m.Isdeleted == false)
                    .Select(m => new TblMandateimages
                    {
                        Fileid = m.Fileid,
                        Mandateid = m.Mandateid,
                        Description = m.Description,
                        Mime = m.Mime
                    }).ToList();
            };
            return Json(files);
        }

        [HttpGet]
        public IActionResult LoadMandateDocument(int id)
        {
            TblMandateimages document;
            using (var db = new TheCoreBankingFileContext())
            {
                document = db.TblMandateimages
                    .Where(m => m.Fileid == id)
                    .Where(m => m.Isdeleted == false)
                    .Select(m => new TblMandateimages
                    {
                        Byte = m.Byte,
                        Mime = m.Mime
                    })
                    .SingleOrDefault();
            };
            if (document == null) return BadRequest();
            return File(document.Byte, document.Mime);
        }

        [HttpGet]
        public JsonResult ListCurrentAccounts()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.Accounts.GetCurrent();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Accountnumber,
                    Text = $"{item.Accountnumber} - {item.Accountname}"
                });
            }
            return Json(list);
        }

        [HttpGet]
        public JsonResult ListChequeAccounts()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.Accounts.GetChequeAccounts();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Accountnumber,
                    Text = $"{item.Accountnumber} - {item.Accountname}"
                });
            }
            return Json(list);
        }

        [HttpGet]
        public JsonResult ListAccountNoMapDetails()
        {
            var list = new List<SelectTwoContent>();
            var result = CustomerUnitOfWork.Accounts.GetAll();
            foreach (var item in result)
            {
                list.Add(new SelectTwoContent
                {
                    Id = item.Accountnumber,
                    Text = $"{item.Accountnumber} - {item.Accountname}"
                });
            }
            return Json(list);
        }

#endregion

        // utilities
        public static string GetRandNo(int length)
        {
            byte[] number = new byte[6];
            new Random().NextBytes(number);
            var random = new BigInteger(number).ToString();
            return random.Substring(random.Length - length);
        }
    }
}