using System;

namespace TheCoreBanking.Customer.ViewModel
{
    public class FreezeAccountVM
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public decimal? Balance { get; set; }
        public decimal FreezeAmount { get; set; }
        public int? FreezeTypeId { get; set; }
        public string CreatedBy;
        public DateTime DateTimeCreated;
        //public DateTime startDate;
        public int Approved;
       
    }

    
}
