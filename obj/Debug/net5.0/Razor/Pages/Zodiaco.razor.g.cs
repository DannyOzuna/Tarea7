#pragma checksum "C:\Users\danny\Desktop\Tarea7\Pages\Zodiaco.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4378a85696fe7a2f0f804aafff0d9ecbd4852a7d"
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
#nullable restore
#line 14 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/zodiaco")]
    public partial class Zodiaco : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row justify-content-center\"><div class=\"col-8\"><div class=\"alert alert-info text-center\"><h1>Lista de Vacunas con signo zodiacal </h1></div></div></div>\r\n\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-hover");
            __builder.AddMarkupContent(3, "<thead><tr><th>Vacunas Registrada</th> \r\n      <th>Personas Vacunadas</th></tr></thead>\r\n  ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 25 "C:\Users\danny\Desktop\Tarea7\Pages\Zodiaco.razor"
     if(lsVacunar != null){
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\danny\Desktop\Tarea7\Pages\Zodiaco.razor"
       foreach (var item in lsVacunar)
      
      {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<tr class=\"table-active\"></tr>");
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddAttribute(8, "colspan", "1");
            __builder.AddAttribute(9, "class", "table-active");
            __builder.AddContent(10, 
#nullable restore
#line 32 "C:\Users\danny\Desktop\Tarea7\Pages\Zodiaco.razor"
                                                item.zodiaco

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, " \r\n          ");
            __builder.OpenElement(12, "td");
            __builder.AddAttribute(13, "colspan", "1");
            __builder.AddAttribute(14, "class", "table-active");
            __builder.AddContent(15, 
#nullable restore
#line 33 "C:\Users\danny\Desktop\Tarea7\Pages\Zodiaco.razor"
                                                item.cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\danny\Desktop\Tarea7\Pages\Zodiaco.razor"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\danny\Desktop\Tarea7\Pages\Zodiaco.razor"
       

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\danny\Desktop\Tarea7\Pages\Zodiaco.razor"
      
    List<ZodiacoJoin> lsVacunar = null;
    protected override async Task OnInitializedAsync(){
        lsVacunar = await RepositorioVacuna.ConsultaZodiaco();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorioVacuna RepositorioVacuna { get; set; }
    }
}
#pragma warning restore 1591
