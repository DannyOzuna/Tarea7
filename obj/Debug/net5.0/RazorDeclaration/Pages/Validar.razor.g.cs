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
#nullable restore
#line 2 "C:\Users\danny\Desktop\Tarea7\Pages\Validar.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danny\Desktop\Tarea7\Pages\Validar.razor"
using Tarea7.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danny\Desktop\Tarea7\Pages\Validar.razor"
using Tarea7.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danny\Desktop\Tarea7\Pages\Validar.razor"
using Tarea7.Data.Repositorio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/validar")]
    public partial class Validar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "C:\Users\danny\Desktop\Tarea7\Pages\Validar.razor"
      
    int id = 0;
    string cedula = "";
    bool errores = false, validarDosis = false;
    DateTime fecha = DateTime.Now;
    DatosCedula datosCedula = null;
    Persona persona = new Persona(); 
    ObtenerSigno signo = new ObtenerSigno();
    List<Vacuna> lsVacuna = new List<Vacuna>();
    List<Provincias> lsProvincia = new List<Provincias>();
    List<Persona> lsPersona = new List<Persona>();

    private async Task Obtener(){
        errores = false;
        var Url = "https://api.adamix.net/apec/cedula/" + cedula;
        datosCedula = await Http.GetFromJsonAsync<DatosCedula>(Url);
        if(datosCedula.ok){
            persona.nombre = datosCedula.Nombres;
            persona.apellido = datosCedula.Apellido1 + " " + datosCedula.Apellido2;
            persona.fecha_nacimiento = Convert.ToDateTime(datosCedula.FechaNacimiento);
            persona.cedula = cedula;
        }else{
            errores = true;
        }

        //Esto para valirdar si el usuarario esta registrodo y mostromos sus datos 

        var personadb = await RepositorioPersona.Get(cedula);
        if(personadb != null){
            id = personadb.id;
            persona.provincia = personadb.provincia;
            persona.telefono = personadb.telefono;
            persona.id_vacuna = personadb.id_vacuna;
            persona.cedula = personadb.cedula;
            persona.fecha_vacuna1 = personadb.fecha_vacuna1;
            persona.estado = personadb.estado;
            if(personadb.fecha_vacuna2 != null){
                validarDosis = true;
            }
        }
    }

    protected override async Task OnInitializedAsync(){
        errores = false;
        lsVacuna = await RepositorioVacuna.Select();
        lsProvincia = await RepositorioProvincia.Get();
        lsPersona = await RepositorioPersona.Get();
        persona.fecha_vacuna1 = fecha;
        persona.fecha_vacuna2 = fecha;
        persona.fecha_nacimiento = fecha;
    }

    private async Task GuardarDatos(){
        errores = false;
        int dia = Convert.ToInt16(Convert.ToDateTime(persona.fecha_nacimiento).ToString("dd"));
        int mes = Convert.ToInt16(Convert.ToDateTime(persona.fecha_nacimiento).ToString("MM"));
        persona.SignoZodiacal = signo.signo(dia,mes).ToUpper();
        var rsCrear = await RepositorioPersona.Add(persona);
        if(rsCrear == null){
            var rsModificar = await RepositorioPersona.Update(id, persona);
        }
        var ver =  await RepositorioPersona.Get(cedula);
        if(ver !=  null){
            id = ver.id;
        }
        var rs = await js.InvokeAsync<object>("msjAlert", "Registrado Correctamente", "success");
        NavigationManager.NavigateTo("/registrovacuna/"+id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorioPersona RepositorioPersona { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProvincias RepositorioProvincia { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorioVacuna RepositorioVacuna { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
