using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoreBanking.Customer.Data.ProcedureAndFunctionDTO
{
   public class GetACCRUDECHARGES
    { 
        public int Id { get; set; }
        public decimal InteresetAccude { get; set; }
        public decimal COTAccude { get; set; }
        public decimal SMSAccude { get; set; }
        public decimal FreezeAmount { get; set; }
        public decimal ChargesAccrue { get; set; }
        public decimal EndBalance { get; set; }
        //public decimal PayableAmount { get; set; }
        public decimal PayableAmount
        {
            get
            {
                return (EndBalance + InteresetAccude + FreezeAmount) - SMSAccude - COTAccude - ChargesAccrue;
            }
        }


    }
    public class ChargesPending
    {
        public int Id { get; set; }
        public decimal pendings { get; set; }
    }

    public class ResponseModel
    {
        public string Message { set; get; }
        public bool Status { set; get; }
        public object Data { set; get; }
    }
}
