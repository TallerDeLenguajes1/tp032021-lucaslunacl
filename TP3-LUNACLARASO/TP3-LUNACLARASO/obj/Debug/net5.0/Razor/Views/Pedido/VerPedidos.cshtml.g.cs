#pragma checksum "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerPedidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c50c923ac37188ed47a87f40f1e7973597c610c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_VerPedidos), @"mvc.1.0.view", @"/Views/Pedido/VerPedidos.cshtml")]
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
#line 1 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\_ViewImports.cshtml"
using TP3_LunaClaraso;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\_ViewImports.cshtml"
using TP3_LunaClaraso.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c50c923ac37188ed47a87f40f1e7973597c610c8", @"/Views/Pedido/VerPedidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b920c0d956a4ebe1529c1ecaedcce09b5f589e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_VerPedidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cadeteria>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AltaPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerPedidos.cshtml"
  
    ViewData["Title"] = "Ver Pedidos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--TABLA DE PEDIDOS-->
<h5>LISTADO DE PEDIDOS </h5>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Nombre del Cliente</th>
            <th scope=""col"">Direccion del Cliente</th>
            <th scope=""col"">Teléfono del Cliente</th>
            <th scope=""col"">Observacion</th>
            <th scope=""col"">Estado</th>
            
            <th scope=""col"">Acciones</th>



        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerPedidos.cshtml"
         foreach (var item in Model.Pedidos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 31 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerPedidos.cshtml"
                       Write(item.Nro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerPedidos.cshtml"
           Write(item.Cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerPedidos.cshtml"
           Write(item.Cliente.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerPedidos.cshtml"
           Write(item.Cliente.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerPedidos.cshtml"
           Write(item.Observacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerPedidos.cshtml"
           Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           \r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerPedidos.cshtml"
           Write(Html.ActionLink("Eliminar", "EliminarPedido", new { idPedido = item.Nro }, new { @class = "btnagre" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerPedidos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c50c923ac37188ed47a87f40f1e7973597c610c87867", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn btn-success\">Añadir Pedido</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cadeteria> Html { get; private set; }
    }
}
#pragma warning restore 1591
