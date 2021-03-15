// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\_Imports.razor"
using Tarea7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\_Imports.razor"
using Tarea7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\Pages\Configuracion.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\Pages\Configuracion.razor"
using Tarea7.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\Pages\Configuracion.razor"
using Tarea7.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\Pages\Configuracion.razor"
using Tarea7.Data.Repositorio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Configuracion")]
    public partial class Configuracion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 179 "D:\5 cuatrimestre\Programación III\unidad 7\Tarea7\Pages\Configuracion.razor"
 
     [Parameter]
    public int id {get; set;}

    public int idEditar {get; set;}
    Vacuna vacuna = new Vacuna();
    List<Vacuna> listarvacuna = new List<Vacuna>();
    List<Vacuna> lista = new List<Vacuna>();

    //  vacunalista VAS = new vacunalista();
        
    
    protected override async Task OnInitializedAsync()
    {
        listarvacuna = await RepositorioVacuna.Get();



    }

     
    public async Task buscar(){

      NavigationManager.NavigateTo("/EditarVacuana/"+ idEditar);
    }

        public async Task EliminarVacuna(int id)
        {
            var confimacion = await js.InvokeAsync<bool>("msjConfim", "Confimar", "Seguro de borrar la vacuna?", "question");
            if(confimacion)
            {
                 await RepositorioVacuna.Delete(id);
                  await js.InvokeAsync<object>("msjAlert", "Eliminado Correctamente", "success");
                    listarvacuna = await RepositorioVacuna.Get();
                
            }
            else
            {
                await js.InvokeAsync<object>("msjAlert", "Ok", "success");
            }

        }

  public async Task GuardarDatos()
  {    
      var rs = await RepositorioVacuna.Add(vacuna);
      if(rs != null){
            await js.InvokeAsync<object>("msjAlert", "Registrado Correctamente", "success");
              listarvacuna = await RepositorioVacuna.Get();
                NavigationManager.NavigateTo("/Configuracion");
                 
        }  
  }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorioVacuna RepositorioVacuna { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
