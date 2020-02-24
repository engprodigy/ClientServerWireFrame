using System;
using System.Collections.Generic;

namespace TheCoreBanking.Customer.Models
{
    public partial class TblCreditAppraisalAttachment
    {
        public int AppraisalAttachmentId { get; set; }
        public string CreditAccountNo { get; set; }
        public int MemoId { get; set; }
        public string AppraisalAttachmentPath { get; set; }
        public byte[] AppraisalAttachmentImage { get; set; }
        public string AppraisalAttachmentTitle { get; set; }
        public string AppraisalAttachmentRemark { get; set; }
        public string AttachedBy { get; set; }
        public string AttachedDate { get; set; }
    }
}
