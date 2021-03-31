using BlazorExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Pages
{
    public partial class InvoiceSample
    {
        public List<InvoiceRow> ExampleInvoiceRows { get; set; }

        protected override void OnInitialized()
        {
            ExampleInvoiceRows = new List<InvoiceRow>
            {
                new InvoiceRow{ IdRow=1, Description="Milk", Qta=5, Price=3},
                new InvoiceRow{ IdRow=2, Description="Banana", Qta=7, Price=2},
                new InvoiceRow{ IdRow=2, Description="Apple", Qta=15, Price=1}

            };

            base.OnInitialized();
        }
    }
}
