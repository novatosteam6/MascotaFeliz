#pragma checksum "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\ListaVeterinarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "665f5fdbcc285e61730252423f6fef0eb2344fa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Veterinarios.Pages_Veterinarios_ListaVeterinarios), @"mvc.1.0.razor-page", @"/Pages/Veterinarios/ListaVeterinarios.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Veterinarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665f5fdbcc285e61730252423f6fef0eb2344fa0", @"/Pages/Veterinarios/ListaVeterinarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Veterinarios_ListaVeterinarios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formulario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("./DetallesVeterinarios"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/pencil-fill.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/delete-bin-5-line.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("eliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
 <div class=""cont-botones"">
            <a class=""btn"" href=""#modal-registrar"">Registrar Veterinario</a>
            <a class=""btn"" href=""#modal-consultar"">Consultar Veterinario</a>
            <button class=""btn btn-list"">Enlistar Veterinarios</button>
        </div>

        <div id=""modal-registrar"" class=""modal-form"">
            <div class=""caja-modal mover-modal"">
                <a href=""#cerrar"" title=""cerrar"" class=""cerrar"">X</a>

                <h2>Registrar Veterinario:</h2>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "665f5fdbcc285e61730252423f6fef0eb2344fa06404", async() => {
                WriteLiteral(@"

                    <label for=""inRegCedulaVeterinario"">Cedula Veterinario:</label>
                    <input type=""text"" id=""inRegCedulaVeterinario"">

                    <label for=""inRegNombresVeterinario"">Nombres Veterinario:</label>
                    <input type=""text"" id=""inRegNombresVeterinario"">
            
                    <label for=""inRegApellidosVeterinario"">Apellidos Veterinario:</label>
                    <input type=""text"" id=""inRegApellidosVeterinario"">
            
                    <label for=""inRegDireccionVeterinario"">Dirección Veterinario:</label>
                    <input type=""text"" id=""inRegDireccionVeterinario"">
            
                    <label for=""inRegTelefonoVeterinario"">Telefono Veterinario:</label>
                    <input type=""text"" id=""inRegTelefonoVeterinario"">
            
                    <label for=""inRegTerjetaVeterinario"">Tarjeta Veterinario:</label>
                    <input type=""text"" id=""inRegTerjetaVeterinario"">
        ");
                WriteLiteral("    \r\n                    <input type=\"submit\" class=\"btn\" value=\"Registrar\">\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>

        <div id=""modal-editar"" class=""modal-form"">
            <div class=""caja-modal mover-modal"">
                <a href=""#cerrar"" title=""cerrar"" class=""cerrar"">X</a>

                <h2>Editar Veterinario:</h2>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "665f5fdbcc285e61730252423f6fef0eb2344fa09201", async() => {
                WriteLiteral(@"

                    <label for=""inEditCedulaVeterinario"">Cedula Veterinario:</label>
                    <input type=""text"" id=""inEditCedulaVeterinario"">

                    <label for=""inEditNombresVeterinario"">Nombres Veterinario:</label>
                    <input type=""text"" id=""inEditNombresVeterinario"">
            
                    <label for=""inEditApellidosVeterinario"">Apellidos Veterinario:</label>
                    <input type=""text"" id=""inEditApellidosVeterinario"">
            
                    <label for=""inEditDireccionVeterinario"">Dirección Veterinario:</label>
                    <input type=""text"" id=""inEditDireccionVeterinario"">
            
                    <label for=""inEditTelefonoVeterinario"">Telefono Veterinario:</label>
                    <input type=""text"" id=""inEditTelefonoVeterinario"">
            
                    <label for=""inEditTerjetaVeterinario"">Tarjeta Veterinario:</label>
                    <input type=""text"" id=""inEditTerjetaVeterinario");
                WriteLiteral("\">\r\n            \r\n                    <input type=\"submit\" class=\"btn\" value=\"Editar\">\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>

        <div id=""modal-consultar"" class=""modal-form"">
            <div class=""caja-modal mover-modal"">
                <a href=""#cerrar"" title=""cerrar"" class=""cerrar"">X</a>

                <h2>Consultar Veterinario:</h2>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "665f5fdbcc285e61730252423f6fef0eb2344fa012015", async() => {
                WriteLiteral(@"
                    <label for=""inconsulIdVeterinario"">Id Veterinario:</label>
                    <input type=""text"" id=""inconsulIdVeterinario"" name=""veterinarioId"">
            
                    <input type=""submit"" class=""btn"" value=""Consultar"">
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>

        <div id=""modal-eliminar"" class=""modal-form"">
            <div class=""caja-modal mover-modal"">
                <a href=""#cerrar"" title=""cerrar"" class=""cerrar"">X</a>

                <h2>Eliminar Veterinario:</h2>
                <p>Esta seguro de eliminar este Registro?</p>
                <button class=""btn btn-sip"">Sip!</button>
                <a class=""btn btn-nope"" href=""#cerrar"">Nope!</a>
            </div>
        </div>

        <div class=""cont-tabla"">
            <table class=""tabla"">
                <tr>
                    <th>Id</th>
                    <th>Cedula</th>
                    <th>Nombres</th>
                    <th>Apellidos</th>
                    <th>Dirección</th>
                    <th>Telefono</th>
                    <th>Tarjeta profesional</th>
                    <th>Editar</th>
                    <th>Eliminar</th>
                </tr>
");
#nullable restore
#line 110 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\ListaVeterinarios.cshtml"
                 foreach (var veterinario in Model.listaVeterinarios)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                    <td>");
#nullable restore
#line 113 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\ListaVeterinarios.cshtml"
                   Write(veterinario.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 114 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\ListaVeterinarios.cshtml"
                   Write(veterinario.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 115 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\ListaVeterinarios.cshtml"
                   Write(veterinario.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 116 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\ListaVeterinarios.cshtml"
                   Write(veterinario.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 117 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\ListaVeterinarios.cshtml"
                   Write(veterinario.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 118 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\ListaVeterinarios.cshtml"
                   Write(veterinario.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 119 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\ListaVeterinarios.cshtml"
                   Write(veterinario.TarjetaProfesional);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn-a\" href=\"#modal-editar\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "665f5fdbcc285e61730252423f6fef0eb2344fa017672", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn-a\" href=\"#modal-eliminar\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "665f5fdbcc285e61730252423f6fef0eb2344fa018976", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 130 "C:\Users\Juank\Desktop\proyectoCiclo3\mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\ListaVeterinarios.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n               \r\n            </table>\r\n        </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.ListaVeterinariosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListaVeterinariosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListaVeterinariosModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.ListaVeterinariosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
