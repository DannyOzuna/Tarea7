#pragma checksum "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f36e97db85ca722e2308ecdb2a44943475a7c47"
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
#line 13 "C:\Users\danny\Desktop\Tarea7\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
using Tarea7.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
using Tarea7.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
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
            __builder.AddMarkupContent(0, "<div class=\"row justify-content-center\"><div class=\"col-8\"><div class=\"alert alert-info text-center\"><h1>Configuracion de Vacuna</h1></div></div></div>\r\n\r\n\r\n<div class=\"d-flex bd-highlight\"></div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div class=""d-flex bd-highlight""><div class=""p-2 flex-grow-1 bd-highlight""><button type=""button"" class=""btn btn-primary p-2 flex-grow-1 bd-highlight"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">
  Agregar Nueva Vacuna
   </button></div>
   

   <div class=""p-2 bd-highlight""><button type=""button"" class=""btn btn-danger p-2 bd-highlight"" data-bs-toggle=""modal"" data-bs-target=""#ModalEliminar"">
      Eliminar
     </button></div>
 
 <div class=""p-2 bd-highlight""><button type=""button"" class=""btn btn-success p-2 bd-highlight"" data-bs-toggle=""modal"" data-bs-target=""#ModalEditarbuscar"">
      Editar
     </button></div></div>

<br>
<br>


");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "modal fade");
            __builder.AddAttribute(4, "id", "ModalEliminar");
            __builder.AddAttribute(5, "tabindex", "-1");
            __builder.AddAttribute(6, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(7, "aria-hidden", "true");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-dialog modal-dialog-centered");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.AddMarkupContent(12, "<div class=\"modal-header\"><h5 class=\"modal-title\" id=\"exampleModalLabel\">Digite el id que quiere Eliminar</h5>\r\n        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Close\"></button></div>\r\n      ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-body");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                                                              id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => id = __value, id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n      ");
            __builder.AddMarkupContent(21, "<div class=\"modal-footer\"><button type=\"button\" class=\"btn btn-secondary\" data-bs-dismiss=\"modal\">Close</button>\r\n        <button type=\"button\" class=\"btn btn-primary\">Save changes</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "modal fade");
            __builder.AddAttribute(25, "id", "exampleModal");
            __builder.AddAttribute(26, "tabindex", "-1");
            __builder.AddAttribute(27, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(28, "aria-hidden", "true");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "modal-dialog modal-dialog-centered");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "modal-content");
            __builder.AddMarkupContent(33, "<div class=\"modal-header\"><h5 class=\"modal-title\" id=\"exampleModalLabel\">Agregar Vacuna</h5>\r\n        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Close\"></button></div>\r\n      ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(36);
            __builder.AddAttribute(37, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 81 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                        vacuna

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 81 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                                                 () => GuardarDatos()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "card-body shadow p-3 mb-5 bg-body rounded");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(42);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n                ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "row justify-content-center mb-3");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-4");
                __builder2.AddMarkupContent(48, "<label>Marca:</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                                                vacuna.marca

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacuna.marca = __value, vacuna.marca))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vacuna.marca));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n                        ");
                __Blazor.Tarea7.Pages.Configuracion.TypeInference.CreateValidationMessage_0(__builder2, 55, 56, 
#nullable restore
#line 88 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                                                () =>vacuna.marca

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\r\n                    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "col-4");
                __builder2.AddMarkupContent(60, "<label>Cantidad:</label>\r\n                        ");
                __Blazor.Tarea7.Pages.Configuracion.TypeInference.CreateInputNumber_1(__builder2, 61, 62, "form-control", 63, 
#nullable restore
#line 93 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                                                  vacuna.cantidad

#line default
#line hidden
#nullable disable
                , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacuna.cantidad = __value, vacuna.cantidad)), 65, () => vacuna.cantidad);
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __Blazor.Tarea7.Pages.Configuracion.TypeInference.CreateValidationMessage_2(__builder2, 67, 68, 
#nullable restore
#line 94 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                                                () =>vacuna.cantidad

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                \r\n                        ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "col-4");
                __builder2.AddMarkupContent(72, "<label>Estado:</label>\r\n                            ");
                __Blazor.Tarea7.Pages.Configuracion.TypeInference.CreateInputSelect_3(__builder2, 73, 74, "form-control", 75, 
#nullable restore
#line 99 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                                                      vacuna.estado

#line default
#line hidden
#nullable disable
                , 76, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vacuna.estado = __value, vacuna.estado)), 77, () => vacuna.estado, 78, (__builder3) => {
                    __builder3.AddMarkupContent(79, "<option value=\"1\">Activo</option>\r\n                                ");
                    __builder3.AddMarkupContent(80, "<option value=\"0\">No Activo </option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n                    ");
                __builder2.AddMarkupContent(82, "<div class=\"modal-footer\"><button type=\"button\" class=\"btn btn-secondary\" data-bs-dismiss=\"modal\">Close</button>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Agregar</button></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(84, "table");
            __builder.AddAttribute(85, "class", "table table");
            __builder.AddMarkupContent(86, "<thead><tr><th scope=\"col\">Id</th>\r\n      <th scope=\"col\">Marca</th>\r\n      <th scope=\"col\">Cantidad</th>\r\n      <th scope=\"col\">Estatus</th>\r\n      <th scope=\"col\">Opciones</th></tr></thead>\r\n  ");
            __builder.OpenElement(87, "tbody");
#nullable restore
#line 137 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
         foreach (var item in listarvacuna)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(88, "tr");
            __builder.OpenElement(89, "td");
            __builder.AddContent(90, 
#nullable restore
#line 140 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                    item.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n               ");
            __builder.OpenElement(92, "td");
            __builder.AddContent(93, 
#nullable restore
#line 141 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                    item.marca

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n               ");
            __builder.OpenElement(95, "td");
            __builder.AddContent(96, 
#nullable restore
#line 142 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                    item.cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n               ");
            __builder.OpenElement(98, "td");
            __builder.AddContent(99, 
#nullable restore
#line 143 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                    item.estado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n              ");
            __builder.OpenElement(101, "td");
            __builder.OpenElement(102, "a");
            __builder.AddAttribute(103, "href", "/EditarVacuana/" + (
#nullable restore
#line 145 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                                         item.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "class", "btn btn-success");
            __builder.AddContent(105, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                ");
            __builder.OpenElement(107, "button");
            __builder.AddAttribute(108, "class", "btn btn-danger");
            __builder.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 146 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
                                                         (() => EliminarVacuna(item.id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(110, "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 150 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 158 "C:\Users\danny\Desktop\Tarea7\Pages\Configuracion.razor"
 
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
namespace __Blazor.Tarea7.Pages.Configuracion
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591