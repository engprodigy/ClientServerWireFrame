using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;

namespace TheCoreBanking.Customer.Controllers
{
    public class FreezeSetupController : Controller
    {
        public ICustomerUnitOfWork CustomerUnitOfWork { get; }
        private readonly IHostingEnvironment hostingEnvironment;
        //private ILogger<AccountFreezeController> logger;
        public FreezeSetupController(IHostingEnvironment _hostingEnvironment, ICustomerUnitOfWork customerUnitOfWork)
        {
            hostingEnvironment = _hostingEnvironment;
            CustomerUnitOfWork = customerUnitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region Create Freeze Operation
        public JsonResult CreateFreezeOperation(string FreezeType2,bool Active2)
        {
            var result = string.Empty;
            if (ModelState.IsValid)
            {
                var type = new TblFreezetype()
                {
                    FreezeType = FreezeType2,
                    Active = Active2
                };
                CustomerUnitOfWork.Freezetype.Add(type);
                CustomerUnitOfWork.Commit();
                result = "Successful";
            }
            else
            {
                result = string.Empty;
            }
            return Json(result);
        }

        public JsonResult CreateFreezeReasonOperation(string FreezeReason2)
        {
            var result = string.Empty;
            if (ModelState.IsValid)
            {
                var reason = new TblFreezereasontype()
                {
                    Reason = FreezeReason2
                };
                CustomerUnitOfWork.Reasontype.Add(reason);
                CustomerUnitOfWork.Commit();
                result = "Successful";
            }
            else
            {
                result = string.Empty;
            }
            return Json(result);
        }
        //[HttpPost]
        //public JsonResult CreateFreezeDateTypeOperation(string FreezeDateType)
        //{
        //    var result = string.Empty;
        //    if (ModelState.IsValid)
        //    {
        //        var dateType = new TblFreezedatetype()
        //        {
        //            DateType = FreezeDateType
        //        };
        //        CustomerUnitOfWork.FreezeDatatype.Add(dateType);
        //        CustomerUnitOfWork.Commit();
        //        result = "Successful";
        //    }
        //    else
        //    {
        //        result = string.Empty;
        //    }
        //    return Json(result);
        //}

        [HttpPost]
        public JsonResult CreateFreezeTransactionOperation(string FreezeTransaction2, string Code, string Description)
        {
            var result = string.Empty;
            if (ModelState.IsValid)
            {
                var transaction = new TblFreezetransactionlist()
                {
                    FreezeTransaction = FreezeTransaction2,
                    Code = Code,
                    Description = Description
                };
                CustomerUnitOfWork.FreezeTransaction.Add(transaction);
                CustomerUnitOfWork.Commit();
                result = "Successful";
            }
            else
            {
                result = string.Empty;
            }
            return Json(result);
        }

        #endregion
        #region Retrieve Freeze type Operation
        public JsonResult listfreezetype()
        {
            var result = CustomerUnitOfWork.Freezetype.GetAll().ToList();
            return Json(result);
        }
        //public JsonResult listfreezedatetype()
        //{
        //    var result = CustomerUnitOfWork.FreezeDatatype.GetAll().ToList();
        //    return Json(result);
        //}
        public JsonResult listfreezereasontype()
        {
            var result = CustomerUnitOfWork.Reasontype.GetAll().ToList();
            return Json(result);
        }
        public JsonResult listfreezetransaction()
        {
            var result = CustomerUnitOfWork.FreezeTransaction.GetAll().ToList();
            return Json(result);
        }
        #endregion
        #region Update freeze type operation
        [HttpPost]
        public JsonResult UpdateFreezeOperation(string FreezeType2, bool Active2,int rowId)
        {
            var result = string.Empty;
            if (ModelState.IsValid)
            {
                var ftype = CustomerUnitOfWork.Freezetype.GetAll().Where(i => i.Id == rowId).ToList().FirstOrDefault();

                ftype.FreezeType = FreezeType2;
                ftype.Active = Active2;
                CustomerUnitOfWork.Freezetype.Update(ftype);
                CustomerUnitOfWork.Commit();
                result = "Successful";
            }
            else
            {
                result = string.Empty;
            }
            return Json(result);
        }
        public JsonResult UpdateFreezeReasonOperation(string FreezeReason, int rowId)
        {
            var result = string.Empty;
            if (ModelState.IsValid)
            {
                var freason = CustomerUnitOfWork.Reasontype.GetAll().Where(i => i.Id == rowId).ToList().FirstOrDefault();

                freason.Reason = FreezeReason;
                CustomerUnitOfWork.Reasontype.Update(freason);
                CustomerUnitOfWork.Commit();
                result = "Successful";
            }
            else
            {
                result = string.Empty;
            }
            return Json(result);
        }
        //[HttpPost]
        //public JsonResult UpdateFreezeDateTypeOperation(string FreezeDateType, int rowId)
        //{
        //    var result = string.Empty;
        //    if (ModelState.IsValid)
        //    {
        //        var fdatetype = CustomerUnitOfWork.FreezeDatatype.GetAll().Where(i => i.Id == rowId).ToList().FirstOrDefault();

        //        fdatetype.DateType = FreezeDateType;
        //        CustomerUnitOfWork.FreezeDatatype.Update(fdatetype);
        //        CustomerUnitOfWork.Commit();
        //        result = "Successful";
        //    }
        //    else
        //    {
        //        result = string.Empty;
        //    }
        //    return Json(result);
        //}
        [HttpPost]
        public JsonResult UpdateFreezeTransactionOperation(string FreezeTransaction2, string Code,string Description, int rowId)
        {
            var result = string.Empty;
            if (ModelState.IsValid)
            {
                var ftransaction = CustomerUnitOfWork.FreezeTransaction.GetAll().Where(i => i.Id == rowId).ToList().FirstOrDefault();

                ftransaction.FreezeTransaction = FreezeTransaction2;
                ftransaction.Code = Code;
                ftransaction.Description = Description;
                CustomerUnitOfWork.FreezeTransaction.Update(ftransaction);
                CustomerUnitOfWork.Commit();
                result = "Successful";
            }
            else
            {
                result = string.Empty;
            }
            return Json(result);
        }
        #endregion
        #region Delete Freeze type Operations
        public JsonResult RemoveFreezeTransaction(int Id)
        {
            int checkId = 0;
            if (Id == 0)
            {
                checkId = Id;
            }
            else
            {
                CustomerUnitOfWork.FreezeTransaction.Delete(Id);
                CustomerUnitOfWork.Commit();
                checkId = Id;
            }
            return Json(checkId);
        }
        //public JsonResult RemoveFreezeDateType(int Id)
        //{
        //    int checkId = 0;
        //    if (Id == 0)
        //    {
        //        checkId = Id;
        //    }
        //    else
        //    {
        //        CustomerUnitOfWork.FreezeDatatype.Delete(Id);
        //        CustomerUnitOfWork.Commit();
        //        checkId = Id;
        //    }
        //    return Json(checkId);
        //}
        public JsonResult RemoveFreezeType(int Id)
        {
            int checkId = 0;
            if(Id == 0)
            {
                checkId = Id;
            }
            else
            {
                CustomerUnitOfWork.Freezetype.Delete(Id);
                CustomerUnitOfWork.Commit();
                checkId = Id;
            }
            return Json(checkId);
        }
        public JsonResult RemoveFreezeReason(int Id)
        {
            int checkId = 0;
            if (Id == 0)
            {
                checkId = Id;
            }
            else
            {
                CustomerUnitOfWork.Reasontype.Delete(Id);
                CustomerUnitOfWork.Commit();
                checkId = Id;
            }
            return Json(checkId);
        }
        #endregion
    }
}