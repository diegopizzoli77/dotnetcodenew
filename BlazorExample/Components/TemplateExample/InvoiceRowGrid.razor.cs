using BlazorExample.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Components.TemplateExample
{
    public partial class InvoiceRowGrid
    {
        [Parameter]
        public List<InvoiceRow> InvoiceRows { get; set; }


        decimal GetTotaleInvoce()
        {
            return InvoiceRows == null || InvoiceRows.Count == 0 ? 0 : InvoiceRows.Sum(r => r.Qta * r.Price);
        }
    }
}
