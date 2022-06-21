using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Company
    {
        public string Name { get; set; }
        public string Sector { get; set; }
        public string MainProducts { get; set; }
        public DateTime ListedDate { get; set; }
        public int SettlementMonth { get; set; }
        public string Ceo { get; set; }
        public string Region { get; set; }
    }
}