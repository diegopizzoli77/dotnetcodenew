using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Components
{
    public partial class GridTemplate<T> : ComponentBase
    {
       
        [Parameter]
        public RenderFragment GridColumnHeader { get; set; }

        [Parameter]
        public RenderFragment<T> GridRow { get; set; }

        [Parameter]
        public RenderFragment GridFooter { get; set; }

        [Parameter]

        public List<T> GridItems { get; set; }


    }
}
