using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp.Models
{
   public class InQuestion
    {
        [PrimaryKey, Indexed]
        public int No { get; set; }

            public int DaysBegin { get; set; }

            public int DaysEnd { get; set; }

            public decimal Interest { get; set; }

            public decimal SrInterest { get; set; }

       

    }
}
