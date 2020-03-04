using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting; 
using Microsoft.Extensions.Logging;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;
using TheCoreBanking.Customer.ViewModels; 
using TheCoreBanking.Customer.Data.ProcedureAndFunctionDTO;
using TheCoreBanking.Customer.Data.Helpers;
using Newtonsoft.Json;

namespace TheCoreBanking.Customer.Controllers
{
    public class AccountServicesController : Controller
    {

        private readonly ICustomerUnitOfWork _DbContext;

        public AccountServicesController(ICustomerUnitOfWork uow)
        {
            _DbContext = uow;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult listAccountsForClosure()
        {
            var result = _DbContext.Accounts.GetAccountWaitingForClosure();
            return Json(result);
        }

        public JsonResult listClosedAndApprovedAccounts()
        {
            //var Account = _DbContext.Accounts.GetClosedAccount().FirstOrDefault().Accountnumber;
            var result = _DbContext.Accounts.GetClosedAccount();
            return Json(result);
        }
        public JsonResult listCloseAccountPending()
        {
            // _DbContext.ClosuredAccount.InsertAccountClosure()
            var result = _DbContext.ClosuredAccount.GetPendingToApproveForClosure();
            return Json(result);
        }


         

        public JsonResult listPendingCharges(string accountNumber)
        {
            var interest = 1;
            var COT = 2;
            var SMS = 3;
            var Freeze = 4;
            var Charges = 5;
            var balance = 6;
            List<ResponseModel> _objResponseModel = new List<ResponseModel>();
            List<GetACCRUDECHARGES> acrruedcharge = new List<GetACCRUDECHARGES>();
            acrruedcharge.Add(new GetACCRUDECHARGES
            {
                InteresetAccude = _DbContext.ClosuredAccount.ClosedAcctAccruedCharges(accountNumber, interest),
                SMSAccude = _DbContext.ClosuredAccount.ClosedAcctAccruedCharges(accountNumber, SMS),
                COTAccude = _DbContext.ClosuredAccount.ClosedAcctAccruedCharges(accountNumber, COT),
                FreezeAmount = _DbContext.ClosuredAccount.ClosedAcctAccruedCharges(accountNumber, Freeze),
                ChargesAccrue = _DbContext.ClosuredAccount.ClosedAcctAccruedCharges(accountNumber, Charges),
                EndBalance = _DbContext.ClosuredAccount.ClosedAcctAccruedCharges(accountNumber, balance),
                

            });


            CloseDetailsModel loadFormat = new CloseDetailsModel();
            List<SelectContentClose> list = new List<SelectContentClose>();
            foreach (var item in acrruedcharge)
            {
                SelectContentClose load = new SelectContentClose()
                {
                    chargesCalculation = item.ChargesAccrue.ToString(),
                    cotCalculation = item.COTAccude.ToString(),
                    freezePlaced = item.FreezeAmount.ToString(),
                    interestCalculation = item.InteresetAccude.ToString(),
                    smsCalculation = item.SMSAccude.ToString(),
                    endbal = item.EndBalance.ToString(),
                    payable = Convert.ToString(item.PayableAmount)
                    
                };

                list.Add(load);
            }
            loadFormat.results = list;
            return Json(loadFormat);

        }









        //public JsonResult loadGLBalance(string AccountID)
        //{
        //    decimal balance = _DbContext.ClosuredAccount.SPGLBalance(AccountID);
        //    return Json(balance);

        //}

        ////Customer Balance
        //public decimal loadCustomerBalance(string AccountID)
        //{
        //    var casa = _DbContext.Accounts.GetAll().Where(o => o.Accountnumber == AccountID).FirstOrDefault();  
        //    decimal balance = _DbContext.ClosuredAccount.CustomerBalance(AccountID);
        //    return balance;

        //}



        #region Post
        
        [HttpPost]

        public JsonResult AddClosedAccounts(string payableamount, string accountnumber, decimal availablebalance, decimal freezeAmount, decimal smsAccude, decimal CotAccude, decimal InteresetAccude, decimal Charges, int Ledgeraccountid, string Comment)       
        {
            
            DateTime time = DateTime.Now;             // Use current time.
            string format = "dd/MMM/yyyy";   // Use this format.
            string chargeDate = time.ToString(format);

            //Get User Name
            var logUser = User.Identity.Name;
            if (logUser == null)
            {
                logUser = "Peter.Okereke";
            }
            else
            {
                logUser = User.Identity.Name;
            }



            // Get Closed Accounts
            var AccountId = _DbContext.Chart.GetAll().Where(p => p.Id == Ledgeraccountid).FirstOrDefault().AccountId;
            //var BranchAndCoy =  listBranchAndCompany(accountnumber);
            var AlreadyClosedExist = _DbContext.Accounts.GetClosedAccount().Where(p => p.Accountnumber == accountnumber).FirstOrDefault();
            var RecordExistOnTBLACCOUNTCLOSURE = _DbContext.ClosuredAccount.GetAll().Where(p => p.Accountnumber == accountnumber).FirstOrDefault();

            bool checkRecord = false;
            if (AlreadyClosedExist != null)
            {
                checkRecord = false; 

                //return Json(new { message = "This Account is Already Closed" });

                return Json(checkRecord);

            }
            else if(RecordExistOnTBLACCOUNTCLOSURE != null)
            {
                checkRecord = false;
                // return Json(new { message = "This Account is Pending For Closure" });
                return Json(checkRecord);

            }
            else if ( accountnumber != null && AccountId != null)
            {
                TblAccountclosure close = new TblAccountclosure();
                close.Accountnumber = accountnumber;
                close.Amountpayable = Convert.ToDecimal(payableamount);
                close.Cotamount = Convert.ToDecimal(CotAccude);
                close.Creditaccount = AccountId;
                close.Datecreated = Convert.ToDateTime(chargeDate);
                close.Interestamount = Convert.ToDecimal(InteresetAccude);
                close.Smsamount = Convert.ToDecimal(smsAccude);
                close.Comment = Comment;
                close.Createdby = logUser;
                close.Branchcode = "101";
                close.Companycode = "1";
                close.Operationid = 1;
                close.Reference = "";

                _DbContext.ClosuredAccount.Add(close);
                _DbContext.Commit();
                checkRecord = true;
            }
            return Json(checkRecord); 
        }

        #endregion


 

 


         
        #region Select2 Helper

        //public class Select2Format

        public class Select2Format
        {
            public List<SelectContent> results { get; set; }
        }
        public class SelectContent
        {
            public string id { get; set; }
            public string text { get; set; }
            public string amount { get; set; }
            public string availablebalance { get; set; }
            public string operationid { get; set; }
            public string approvalstatusid { get; set; }



        }


        public class CloseDetailsModel
        {
            public List<SelectContentClose> results { get; set; }
        }
        public class SelectContentClose
        {

            public string interestCalculation { get; set; }
            public string cotCalculation { get; set; }
            public string smsCalculation { get; set; }
            public string freezePlaced { get; set; }
            public string chargesCalculation { get; set; }
            public string endbal { get; set; }
            public string payable { get; set; }


        }

        #endregion

        #region ChartOfAccount

      



        [HttpGet]
        public JsonResult GetChartOfAccountLocally()
        {
            var list = new List<LedgerContent>();
            var result = _DbContext.Chart.GetAll();
            foreach (var item in result)
            {
                list.Add(new LedgerContent
                {
                    Id = item.Id.ToString(),                 
                    Text = $"{item.AccountName} [{item.AccountId}]",
                    accountname = item.AccountName,
                    accountId = item.AccountId


                });
            }
            return Json(list);
        }


//        public JsonResult LoadBankLedgers()
//        {
//            var list = new List<SelectTwoContent>();
//            string Uri = ApiConstants.BaseApiUrl + ApiConstants.ChartOfAccountEndpoint;
//            var ChartOfAccounts = _DbContext.API.GetAsync(Uri).Result;
//            var settings = new JsonSerializerSettings
//            {
//                NullValueHandling = NullValueHandling.Ignore,
//                MissingMemberHandling = MissingMemberHandling.Ignore
//            };
//            IEnumerable<ChartOfAccountVM> result =
//                JsonConvert.DeserializeObject<IEnumerable<ChartOfAccountVM>>(ChartOfAccounts, settings);
//            foreach (var item in result)
//            {
//                list.Add(new SelectTwoContent
//                {
//                    Id = item.Id.ToString(),
//                    Text = $"{item.AccountName} [{item.Id}]"
//                });
//            }
//            return Json(list);
//        }


//        [HttpGet]
//        public JsonResult GetChartOfAccount()
//        {
//            var list = new List<SelectTwoContent>();
//            var result = LoadChartOfAccounts();
//            foreach (var item in result)
//            {
//                list.Add(new SelectTwoContent
//                {
//                    Id = item.Id.ToString(),
//                    Text = item.AccountName,
//                    accountname = item.AccountName,
//                    accountId = item.AccountID

//                });
//            }
//            return Json(list);
//        }




//        protected IEnumerable<ChartOfAccountVM> LoadChartOfAccounts()
//        {

//#if DEBUG
//            //string URI for out of office development

//            string Uri = ApiConstants.BaseApiUrlDevHome2 + ApiConstants.ChartOfAccountEndpointDev;

//            //for office development

//            //string Uri = ApiConstants.BaseApiUrl + ApiConstants.ChartOfAccountEndpoint;
//#else
//            string Uri = ApiConstants.BaseApiUrl + ApiConstants.ChartOfAccountEndpoint;
//#endif
//            var ChartOfAccounts = _DbContext.API.GetAsync(Uri).Result;
//            var settings = new JsonSerializerSettings
//            {
//                NullValueHandling = NullValueHandling.Ignore,
//                MissingMemberHandling = MissingMemberHandling.Ignore
//            };
//            IEnumerable<ChartOfAccountVM> result =
//                JsonConvert.DeserializeObject<IEnumerable<ChartOfAccountVM>>(ChartOfAccounts, settings);
//            return result;
//        }
         

        #endregion

    }
}