#pragma checksum "C:\Users\danny\Desktop\Tarea7\Pages\Demo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99ef457c5e2f3605258d34a15d5dd58e67e433e9"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using Tarea7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using Tarea7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using Tarea7.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using Tarea7.Data.Repositorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/modal")]
    public partial class Demo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<button type=\"button\" class=\"btn btn-primary\" data-bs-toggle=\"modal\" data-bs-target=\"#exampleModal\">\r\n  Launch demo modal\r\n</button>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true""><div class=""modal-dialog modal-dialog-centered""><div class=""modal-content""><div class=""modal-header""><h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
        <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
      <div class=""modal-body""><p>Modal body text goes here.</p></div>
      <div class=""modal-footer""><button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"">Save changes</button></div></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591