using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheCoreBanking.Customer.ViewModels
{
    public class MandateVM
    {

        public int Mandateid;
        public string CustomerAccountname;
        //public string CustomerAccountnumber;
        public string Signatorysurname { get; set; }
        public string Signatoryothername { get; set; }
        public string Signatoryfirstname { get; set; }
        public string Description { get; set; }


    }
}
