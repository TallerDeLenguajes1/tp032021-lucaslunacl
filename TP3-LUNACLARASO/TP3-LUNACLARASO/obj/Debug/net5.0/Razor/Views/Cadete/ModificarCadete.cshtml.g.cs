#pragma checksum "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Cadete\ModificarCadete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba95ae6ac40363cbb8839c5a1645e82ec1f2f7c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadete_ModificarCadete), @"mvc.1.0.view", @"/Views/Cadete/ModificarCadete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba95ae6ac40363cbb8839c5a1645e82ec1f2f7c3", @"/Views/Cadete/ModificarCadete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b920c0d956a4ebe1529c1ecaedcce09b5f589e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadete_ModificarCadete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cadete>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VerCadetes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cadete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Modificar Cadete</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba95ae6ac40363cbb8839c5a1645e82ec1f2f7c34427", async() => {
                WriteLiteral("\r\n    <fieldset>\r\n        <div>\r\n            <input hidden name=\"id\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 322, "\"", 339, 1);
#nullable restore
#line 12 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Cadete\ModificarCadete.cshtml"
WriteAttributeValue("", 330, Model.Id, 330, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <label for=\"disabledText\" class=\"form-label\">Nombre</label>\r\n            <input type=\"text\" name=\"nombre\" id=\"disabledText\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 545, "\"", 566, 1);
#nullable restore
#line 16 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Cadete\ModificarCadete.cshtml"
WriteAttributeValue("", 553, Model.Nombre, 553, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <label for=\"disabledText\" class=\"form-label\">Direccion</label>\r\n            <input type=\"text\" name=\"direccion\" id=\"disabledText\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 776, "\"", 801, 2);
#nullable restore
#line 20 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Cadete\ModificarCadete.cshtml"
WriteAttributeValue("", 784, Model.Direccion, 784, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 800, "", 801, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <label for=\"disabledText\" class=\"form-label\">Telefono</label>\r\n            <input type=\"text\" name=\"tel\" id=\"disabledText\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1004, "\"", 1028, 1);
#nullable restore
#line 24 "C:\Users\Lucas\Desktop\PRACTICOS FACULTAD\segundo\Taller de Lenguajes 2\tp032021-lucaslunacl\TP3-LUNACLARASO\TP3-LunaClaraso\Views\Cadete\ModificarCadete.cshtml"
WriteAttributeValue(" ", 1012, Model.Telefono, 1013, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n\r\n        <button type=\"submit\" class=\"btn btn-primary\">Modificar</button>\r\n    </fieldset>\r\n");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cadete> Html { get; private set; }
    }
}
#pragma warning restore 1591
