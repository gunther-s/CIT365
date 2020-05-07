using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Schurr
{
    public class DeskQuote
    {
        public DateTime QuoteTime { get; set; }
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }

        //public decimal GetQuote()
        //{
           // Desk.set = 32;
        //}
    }
}
