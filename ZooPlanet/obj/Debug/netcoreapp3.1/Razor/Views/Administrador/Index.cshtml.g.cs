#pragma checksum "C:\Users\robca\Desktop\ZooPlanet - copia\ZooPlanet\Views\Administrador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0db8ec670afdb0d0b33da7d9f0551cd4a2fdc106"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Index), @"mvc.1.0.view", @"/Views/Administrador/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db8ec670afdb0d0b33da7d9f0551cd4a2fdc106", @"/Views/Administrador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZooPlanet.Models.Especies>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Administrador/Agregar/Especie"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\robca\Desktop\ZooPlanet - copia\ZooPlanet\Views\Administrador\Index.cshtml"
  
	Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Especies</h1>\r\n\r\n<table>\r\n    <colgroup>\r\n        <col style=\"width:50px\" />\r\n        <col style=\"width:40px\" />\r\n        <col  />\r\n        <col style=\"width:50%\" />\r\n    </colgroup>\r\n    <caption>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0db8ec670afdb0d0b33da7d9f0551cd4a2fdc1063601", async() => {
                WriteLiteral("<i class=\"fa fa-plus\"></i> Agregar Especie");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </caption>\r\n    <thead>\r\n        <tr>\r\n            <th>#</th>\r\n            <th colspan=\"2\">Especie</th>\r\n            <th>Acciones</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\robca\Desktop\ZooPlanet - copia\ZooPlanet\Views\Administrador\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"center\">");
#nullable restore
#line 29 "C:\Users\robca\Desktop\ZooPlanet - copia\ZooPlanet\Views\Administrador\Index.cshtml"
                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"width:40px\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0db8ec670afdb0d0b33da7d9f0551cd4a2fdc1065511", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 736, "~/clases/", 736, 9, true);
#nullable restore
#line 30 "C:\Users\robca\Desktop\ZooPlanet - copia\ZooPlanet\Views\Administrador\Index.cshtml"
AddHtmlAttributeValue("", 745, item.IdClase, 745, 15, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 760, ".png", 760, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\robca\Desktop\ZooPlanet - copia\ZooPlanet\Views\Administrador\Index.cshtml"
               Write(item.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"center\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 872, "\"", 909, 2);
            WriteAttributeValue("", 879, "/Administrador/Editar/", 879, 22, true);
#nullable restore
#line 33 "C:\Users\robca\Desktop\ZooPlanet - copia\ZooPlanet\Views\Administrador\Index.cshtml"
WriteAttributeValue("", 901, item.Id, 901, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i> Editar</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 972, "\"", 1011, 2);
            WriteAttributeValue("", 979, "/Administrador/Eliminar/", 979, 24, true);
#nullable restore
#line 34 "C:\Users\robca\Desktop\ZooPlanet - copia\ZooPlanet\Views\Administrador\Index.cshtml"
WriteAttributeValue("", 1003, item.Id, 1003, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-remove\"></i> Eliminar</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1078, "\"", 1115, 2);
            WriteAttributeValue("", 1085, "/Administrador/Imagen/", 1085, 22, true);
#nullable restore
#line 35 "C:\Users\robca\Desktop\ZooPlanet - copia\ZooPlanet\Views\Administrador\Index.cshtml"
WriteAttributeValue("", 1107, item.Id, 1107, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-image\"></i> Imagen</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\robca\Desktop\ZooPlanet - copia\ZooPlanet\Views\Administrador\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZooPlanet.Models.Especies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
