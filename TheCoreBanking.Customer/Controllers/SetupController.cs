using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TheCoreBanking.Customer.Data.Contracts;
using TheCoreBanking.Customer.Data.Models;
using TheCoreBanking.Customer.ViewModels;

namespace TheCoreBanking.Customer.Controllers
{
    public class SetupController : Controller
    {
        TheCoreBankingCustomerContext db = new TheCoreBankingCustomerContext();
        private ICustomerUnitOfWork CustomerUnitOfWork { get; }
        public SetupController(ICustomerUnitOfWork uow)
        {
            CustomerUnitOfWork = uow;
        }

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

        #region Create

        [HttpPost]
        public JsonResult AddKycItem([FromBody]TblKycitem KycitemAdd)
        {
           
            KycitemAdd.Datetimecreated = DateTime.Now;
            CustomerUnitOfWork.KYCItems.Add(KycitemAdd);
            CustomerUnitOfWork.Commit();
            return Json(KycitemAdd.Kycitemid);
            

        }

        [HttpPost]
        public JsonResult AddCustTitle([FromBody]TblTitle tblTitle)
        {
            CustomerUnitOfWork.Titles.Add(tblTitle);
            CustomerUnitOfWork.Commit();
            return Json(tblTitle.Id);
        }

        [HttpPost]
        public JsonResult AddIndustrySec([FromBody]TblIndustry industrySec)
        {
            CustomerUnitOfWork.Industries.Add(industrySec);
            CustomerUnitOfWork.Commit();
            return Json(industrySec.Industryid);
        }

        [HttpPost]
        public JsonResult AddSectorSetup([FromBody]TblSector Sectorsetup)
        {
            IQueryable<TblSector> setupTracker =  CustomerUnitOfWork.Sectors.GetSingleByNameOrCode(Sectorsetup);
            //var setupTrackerValue = setupTracker.FirstOrDefault();
            var setupTrackerValue = setupTracker.Count();
            if(setupTrackerValue >= 1)
            {
                return Json(false);
            }
            else {
            CustomerUnitOfWork.Sectors.Add(Sectorsetup);
            CustomerUnitOfWork.Commit();
            return Json(true);
            
            }
        }

        [HttpPost]
        public JsonResult AddAccountType([FromBody]TblCustomeraccounttype accountType)
        {
            CustomerUnitOfWork.CustomerAccountTypes.Add(accountType);
            CustomerUnitOfWork.Commit();
            return Json(accountType.Id);
        }

        [HttpPost]
        public JsonResult AddMaritalStatus([FromBody]TblMaritalstatus custmaritalstatus)
        {
            custmaritalstatus.Datecreated = DateTime.Now;
            CustomerUnitOfWork.MaritalStatuses.Add(custmaritalstatus);
            CustomerUnitOfWork.Commit();
            return Json(custmaritalstatus.Id);
        }

        [HttpPost]
        public JsonResult AddModeOfID([FromBody]TblModeofidentification mode)
        {
            mode.Createddate = DateTime.Now;
            mode.Isdeleted = false;
            CustomerUnitOfWork.ModeOfIDs.Add(mode);
            CustomerUnitOfWork.Commit();
            return Json(mode.Id);
        }

        #endregion

        #region Update

        [HttpPost]
        public JsonResult UpdateKycItem([FromBody]TblKycitem Kycitem)
        {
            Kycitem.Datetimeupdated = DateTime.Now;
            CustomerUnitOfWork.KYCItems.Update(Kycitem);
            CustomerUnitOfWork.Commit();
            return Json(Kycitem.Kycitemid);
        }

        [HttpPost]
        public JsonResult UpdateMaritalStatus([FromBody]TblMaritalstatus Maritalstatus)
        {
            CustomerUnitOfWork.MaritalStatuses.Update(Maritalstatus);
            CustomerUnitOfWork.Commit();
            return Json(Maritalstatus.Id);
        }

        [HttpPost]
        public JsonResult updateCustTitle([FromBody]TblTitle updateTitle)
        {
            CustomerUnitOfWork.Titles.Update(updateTitle);
            CustomerUnitOfWork.Commit();
            return Json(updateTitle.Id);
        }

        [HttpPost]
        public JsonResult UpdateCustAccount([FromBody]TblCustomeraccounttype accounttype)
        {
            CustomerUnitOfWork.CustomerAccountTypes.Update(accounttype);
            CustomerUnitOfWork.Commit();
            return Json(accounttype.Id);
        }

        [HttpPost]
        public JsonResult UpdateModeOfID([FromBody]TblModeofidentification mode)
        {
            CustomerUnitOfWork.ModeOfIDs.Update(mode);
            CustomerUnitOfWork.Commit();
            return Json(mode.Id);
        }

        [HttpPost]
        public JsonResult updateIndustrySec([FromBody]TblIndustry industrysec)
        {
            CustomerUnitOfWork.Industries.Update(industrysec);
            CustomerUnitOfWork.Commit();
            return Json(industrysec.Industryid);
        }

        [HttpPost]
        public JsonResult updateSectorSetup([FromBody]TblSector sectorsetup)
        {
            IQueryable<TblSector> setupCodeTracker = CustomerUnitOfWork.Sectors.GetSingleByCode(sectorsetup);
            IQueryable<TblSector> setupNameTracker = CustomerUnitOfWork.Sectors.GetSingleByName(sectorsetup);

           // var setupTrackerValue = setupCodeTracker.Count();
            if (setupCodeTracker.Count() == 1 && setupNameTracker.Count() == 1)
            {
                //return Json(setupTrackerValue);
                return Json(false);
            }
            else if (setupCodeTracker.Count() == 0 && setupNameTracker.Count() == 1)
            {
                CustomerUnitOfWork.Sectors.Update(sectorsetup);
                CustomerUnitOfWork.Commit();
                //return Json(sectorsetup.Sectorid);
                return Json(true);
            }

            else if (setupCodeTracker.Count() == 1 && setupNameTracker.Count() == 0)
            {
                CustomerUnitOfWork.Sectors.Update(sectorsetup);
                CustomerUnitOfWork.Commit();
                //return Json(sectorsetup.Sectorid);
                return Json(true);
            }

            else if (setupCodeTracker.Count() == 0 && setupNameTracker.Count() == 0)
            {
                CustomerUnitOfWork.Sectors.Update(sectorsetup);
                CustomerUnitOfWork.Commit();
                //return Json(sectorsetup.Sectorid);
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }

       

        [HttpPost]
        public JsonResult CaptureCaption(TblCustomerCustomFields customField)
        {
           // if (customField.Caption1 != "")
           // {//CustomFieldViewModel
                //Data.Models.TblCustomerCustomFields customerfield = new Data.Models.TblCustomerCustomFields();

                using (var db = new TheCoreBankingCustomerContext()) { 

                    var custom = db.TblCustomerCustomFields.Where(i => i.Id > 0).FirstOrDefault();
                //var custom = db.TblCustomerCustomFields.

                  if (custom != null)
                  {
                  custom.Caption1 = customField.Caption1;
                  custom.Caption2 = customField.Caption2;
                  custom.Caption3 = customField.Caption3;
                  custom.Caption4 = customField.Caption4;
                  custom.Caption5 = customField.Caption5;
                  custom.Caption6 = customField.Caption6;
                  custom.Caption7 = customField.Caption7;
                  custom.Caption8 = customField.Caption8;
                  custom.Caption9 = customField.Caption9;
                  custom.Caption10 = customField.Caption10;
                  custom.Caption11 = customField.Caption11;
                  custom.Caption12 = customField.Caption12;
                  custom.Caption13 = customField.Caption13;
                  custom.Caption14 = customField.Caption14;
                  custom.Caption15 = customField.Caption15;
                  custom.Caption16 = customField.Caption16;
                  custom.Caption17 = customField.Caption17;
                  custom.Caption18 = customField.Caption18;
                  custom.Caption19 = customField.Caption19;
                  custom.Caption20 = customField.Caption20;
                  db.TblCustomerCustomFields.Update(custom);

                     db.SaveChanges();
                    return Json(custom);
                }
             // else
             // {*/
                //    db.TblCustomerCustomFields.Add(customField);
                // }
               
                    

            //  }
            }
            return Json(customField);
        }
        #endregion

        public JsonResult CaptureCaptionList()
        {
            // var result = db.TblCustomerCustomFields.ToList();
            //  db.TblCustomerCustomFields.Where(s => s.Id == 2048).FirstOrDefault();
            object custom = null;
            using (var db = new TheCoreBankingCustomerContext())
            {

                //custom = db.TblCustomerCustomFields.Where(i => i.Id > 0).FirstOrDefault();
                custom = db.TblCustomerCustomFields.ToList();

            }

            return Json(custom);
        }

        #region Delete              

        /// <summary>
        /// 
        /// </summary>
        /// <param name="removeTitle"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteCustomerTitle([FromBody]TblTitle removeTitle)
        {
            var item = CustomerUnitOfWork.Titles.GetById(removeTitle.Id);
            item.Isdeleted = true;

            CustomerUnitOfWork.Titles.Update(item);
            CustomerUnitOfWork.Commit();
            return Json(removeTitle.Id);

        }

        [HttpPost]
        public JsonResult DeleteSectorSetup([FromBody]TblSector sectorSetup)
        {
            var item = CustomerUnitOfWork.Sectors.GetById(sectorSetup.Sectorid);
            item.Isdeleted = true;

            CustomerUnitOfWork.Sectors.Update(item);
            CustomerUnitOfWork.Commit();
            return Json(sectorSetup.Sectorid);
        }

        [HttpPost]
        public JsonResult DeleteIndustrySetup([FromBody]TblIndustry industrysec)
        {
            var item = CustomerUnitOfWork.Industries.GetById(industrysec.Industryid);
            item.Isdeleted = true;

            CustomerUnitOfWork.Industries.Update(item);
            CustomerUnitOfWork.Commit();
            return Json(industrysec.Industryid);
        }

        [HttpPost]
        public JsonResult DeleteKycItem([FromBody]TblKycitem removeKyc)
        {
            var item = CustomerUnitOfWork.KYCItems.GetById(removeKyc.Kycitemid);
            item.Isdeleted = true;

            CustomerUnitOfWork.KYCItems.Update(item);
            CustomerUnitOfWork.Commit();
            return Json(removeKyc.Kycitemid);
        }

        [HttpPost]
        public JsonResult DeleteModeOfID([FromBody]TblModeofidentification mode)
        {
            var item = CustomerUnitOfWork.ModeOfIDs.GetById(mode.Id);
            item.Isdeleted = true;

            CustomerUnitOfWork.ModeOfIDs.Update(item);
            CustomerUnitOfWork.Commit();
            return Json(mode.Id);

        }

        [HttpPost]
        public JsonResult DeleteAccountType([FromBody]TblCustomeraccounttype accounttype)
        {
            var item = CustomerUnitOfWork.CustomerAccountTypes.GetById(accounttype.Id);
            item.Isdeleted = true;

            CustomerUnitOfWork.CustomerAccountTypes.Update(item);
            CustomerUnitOfWork.Commit();
            return Json(accounttype.Id);
        }

        [HttpPost]
        public JsonResult DeleteMaritalStatus([FromBody]TblMaritalstatus custMaritalstatus)
        {
            var item = CustomerUnitOfWork.MaritalStatuses.GetById(custMaritalstatus.Id);
            item.Isdeleted = true;

            CustomerUnitOfWork.MaritalStatuses.Update(item);
            CustomerUnitOfWork.Commit();
            return Json(custMaritalstatus.Id);
        }

        #endregion

        #region Fetch

        public JsonResult listMaritalStatus()
        {
            var result = CustomerUnitOfWork.MaritalStatuses.GetActive();
            return Json(result);
        }

        public JsonResult ListTitles()
        {
            var result = CustomerUnitOfWork.Titles.GetActive();
            return Json(result);
        }

        public JsonResult ListModeOfIDs()
        {
            var result = CustomerUnitOfWork.ModeOfIDs.GetActive();
            return Json(result);
        }

        public JsonResult ListCustomerAccountTypes()
        {
            var result = CustomerUnitOfWork.CustomerAccountTypes.GetActive();
            return Json(result);
        }
        
        public JsonResult ListKYCItems()
        {
            var result = CustomerUnitOfWork.KYCItems.GetActive();
            return Json(result);
        }

        public JsonResult ListMaritalStatuses()
        {
            var result = CustomerUnitOfWork.MaritalStatuses.GetAll();
            return Json(result);
        }

        public JsonResult ListSectors()
        {
            var result = CustomerUnitOfWork.Sectors.GetActive();
            return Json(result);
        }

        public JsonResult ListOfIndustry()
        {
            var result = CustomerUnitOfWork.Industries.GetActive();
            return Json(result);
        }

        public JsonResult ListDesignation()
        {
            var result = CustomerUnitOfWork.Designation.GetAll();
            return Json(result);
        }

        #endregion

    }
}