#pragma checksum "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerClientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a2412788ab95750b01f4b9b14c45ccbbe8a5577"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_VerClientes), @"mvc.1.0.view", @"/Views/Pedido/VerClientes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a2412788ab95750b01f4b9b14c45ccbbe8a5577", @"/Views/Pedido/VerClientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b920c0d956a4ebe1529c1ecaedcce09b5f589e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_VerClientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TP3_LunaClaraso.Models.Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerClientes.cshtml"
  
    ViewData["Title"] = "Ver Clientes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--TABLA DE CLIENTES-->
<h5>LISTADO DE CLIENTES </h5>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Nombre del Cliente</th>
            <th scope=""col"">Direccion del Cliente</th>
            <th scope=""col"">Teléfono del Cliente</th>
         </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerClientes.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerClientes.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <th scope=\"row\">");
#nullable restore
#line 24 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerClientes.cshtml"
                       Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerClientes.cshtml"
           Write(item.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerClientes.cshtml"
           Write(item.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Alumno\Documents\GitHub\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Pedido\VerClientes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TP3_LunaClaraso.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
