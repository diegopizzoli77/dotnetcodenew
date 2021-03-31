using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Models
{
    public class InvoiceRow
    {
        public int IdRow { get; set; }

        public string Description { get; set; }

        public int Qta { get; set; }

        public decimal Price { get; set; }
    }
}
