#pragma checksum "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\AltaPedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f02f9675c3b7a1ac5b24b72e5b9ab7f4aa02254"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_AltaPedido), @"mvc.1.0.view", @"/Views/Pedido/AltaPedido.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\_ViewImports.cshtml"
using TP3_LunaClaraso;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\_ViewImports.cshtml"
using TP3_LunaClaraso.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f02f9675c3b7a1ac5b24b72e5b9ab7f4aa02254", @"/Views/Pedido/AltaPedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b920c0d956a4ebe1529c1ecaedcce09b5f589e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_AltaPedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TP3_LunaClaraso.Models.Cadete>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DarAlta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-auto form-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\AltaPedido.cshtml"
  
    ViewData["Title"] = "Agregar Pedido";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"section-padding mx-auto seccion-form\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f02f9675c3b7a1ac5b24b72e5b9ab7f4aa022545111", async() => {
                WriteLiteral("\r\n        <h2 class=\"mb-5 text-center\"");
                BeginWriteAttribute("id", " id=\"", 285, "\"", 290, 0);
                EndWriteAttribute();
                WriteLiteral(@">Nuevo Pedido</h2>
        <div class=""input-group"">
            <span class=""input-group-text"" id=""basic-addon1""><i class=""fas fa-user""></i></span>
            <input type=""text"" class=""form-control"" placeholder=""Nombre del Cliente"" aria-label=""Nombre del Cliente"" aria-describedby=""basic-addon1"" name=""nombre"" required>
        </div>
        <div class=""input-group mt-4"">
            <span class=""input-group-text"" id=""basic-addon1""><i class=""far fa-address-card""></i></span>
            <input type=""text"" class=""form-control"" placeholder=""Direccion del Cliente"" aria-label=""Direccion del Cliente"" aria-describedby=""basic-addon1"" name=""direccion"" required>
        </div>
        <div class=""input-group mt-4"">
            <span class=""input-group-text"" id=""basic-addon1""><i class=""fas fa-mobile-alt""></i></span>
            <input type=""text"" class=""form-control"" placeholder=""Telefono del Cliente"" aria-label=""Telefono del Cliente"" aria-describedby=""basic-addon1"" name=""telefono"" required>
        </div>");
                WriteLiteral(@"
        <div class=""input-group mt-4"">

            <textarea class=""form-control"" placeholder=""Observacion"" aria-label=""Observacion"" aria-describedby=""basic-addon1"" name=""observacion"" required rows=""3""></textarea>
        </div>
        <div class=""input-group mt-4"">
            <span class=""input-group-text"" id=""basic-addon1""><i class=""fas fa-bicycle""></i></span>
            <select class=""form-control"">
");
#nullable restore
#line 28 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\AltaPedido.cshtml"
                 if (Model.Count < 1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f02f9675c3b7a1ac5b24b72e5b9ab7f4aa022547423", async() => {
                    WriteLiteral("-- NO HAY CADETE DISPONIBLE --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\AltaPedido.cshtml"
                }
                else
                {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\AltaPedido.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f02f9675c3b7a1ac5b24b72e5b9ab7f4aa022549055", async() => {
#nullable restore
#line 36 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\AltaPedido.cshtml"
                       Write(item.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\AltaPedido.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\AltaPedido.cshtml"
                 
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n        <button class=\"btn btn-primary w-100 mt-4\" type=\"submit\">Añadir Pedido</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TP3_LunaClaraso.Models.Cadete>> Html { get; private set; }
    }
}
#pragma warning restore 1591
