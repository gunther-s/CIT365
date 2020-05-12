using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Schurr
{
    public class DeskQuote
    {
        private const decimal DESKTOP_BASE = 200.00M;
        private const decimal EXTRA_DESK_PRICE = 1.00M;


        public DateTime QuoteTime { get; set; }
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }

        //public decimal GetQuote()
        //{
           // Desk.set = 32;
        //}
    }
}
