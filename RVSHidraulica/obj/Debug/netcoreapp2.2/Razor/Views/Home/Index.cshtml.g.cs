#pragma checksum "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ebd67a879670ccf9520a825675f2436bc9d2047"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\_ViewImports.cshtml"
using RVSHidraulica;

#line default
#line hidden
#line 2 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\_ViewImports.cshtml"
using RVSHidraulica.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ebd67a879670ccf9520a825675f2436bc9d2047", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"760753f50affd95aefa7174e1ecf0ef27d648c76", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
            BeginContext(42, 38, true);
            WriteLiteral("<link rel=\"stylesheet\" type=\"text/css\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 80, "\"", 136, 1);
#line 4 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Home\Index.cshtml"
WriteAttributeValue("", 87, Url.Content("~/lib/slick-1.8.1/slick/slick.css"), 87, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(137, 43, true);
            WriteLiteral(" />\r\n<link rel=\"stylesheet\" type=\"text/css\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 180, "\"", 242, 1);
#line 5 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Home\Index.cshtml"
WriteAttributeValue("", 187, Url.Content("~/lib/slick-1.8.1/slick/slick-theme.css"), 187, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(243, 27, true);
            WriteLiteral(" />\r\n<link rel=\"stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 270, "\"", 309, 1);
#line 6 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Home\Index.cshtml"
WriteAttributeValue("", 277, Url.Content($"~/css/index.css"), 277, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(310, 645, true);
            WriteLiteral(@" />
<div>
    <div class=""mx-5 mt-5"">
        <h1 class=""text-center font-weight-bold"">Bienvenido a RVS Hidráulica</h1>
        <p class=""mt-4"">
            Somos una empresa joven donde priorizamos el servicio para dar soluciones en el rubro de la hidráulica.
        </p>
        <p>
            Nos enfocamos en la <strong>reparación</strong>, <strong>venta</strong> y <strong>asesoramiento técnico</strong> de equipos oleohidráulicos. Trabajamos con un grupo importante de marcas nacionales e importadas según la necesidad del cliente.
        </p>
    </div>
    <div class=""mt-5 carousel w-100"">
        <div>
            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 955, "\"", 990, 1);
#line 19 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Home\Index.cshtml"
WriteAttributeValue("", 961, Url.Content($"~/img/c1.jpg"), 961, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(991, 50, true);
            WriteLiteral(">\r\n        </div>\r\n        <div>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1041, "\"", 1076, 1);
#line 22 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Home\Index.cshtml"
WriteAttributeValue("", 1047, Url.Content($"~/img/c2.jpg"), 1047, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1077, 50, true);
            WriteLiteral(">\r\n        </div>\r\n        <div>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1127, "\"", 1162, 1);
#line 25 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Home\Index.cshtml"
WriteAttributeValue("", 1133, Url.Content($"~/img/c3.jpg"), 1133, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1163, 62, true);
            WriteLiteral(">\r\n        </div>\r\n        <div>\r\n            <img width=\"50%\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1225, "\"", 1260, 1);
#line 28 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Home\Index.cshtml"
WriteAttributeValue("", 1231, Url.Content($"~/img/c4.jpg"), 1231, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1261, 320, true);
            WriteLiteral(@">
        </div>
    </div>
    <div class=""deg d-flex align-items-center"">
        <p class=""text-right col col-md-6 ml-auto mr-5 font-weight-bold"">
            Nos ponemos a vuestra
            disposición para ofrecerles las más amplias gamas de soluciones a sus necesidades.
        </p>
    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1598, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1611, "\"", 1669, 1);
#line 39 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Home\Index.cshtml"
WriteAttributeValue("", 1617, Url.Content("~/lib/slick-1.8.1/slick/slick.min.js"), 1617, 52, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1670, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1693, "\"", 1728, 1);
#line 40 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Home\Index.cshtml"
WriteAttributeValue("", 1699, Url.Content("~/js/index.js"), 1699, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1729, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(1744, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
