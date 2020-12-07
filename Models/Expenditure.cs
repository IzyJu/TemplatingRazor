using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplatingRazor.Models
{
    public class Expenditure
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        public int price { get; set; }
    }
}
