#pragma checksum "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Servicios\Servicios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "089d44685a450ab051e0bab47b023aa630b0b2d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servicios_Servicios), @"mvc.1.0.view", @"/Views/Servicios/Servicios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Servicios/Servicios.cshtml", typeof(AspNetCore.Views_Servicios_Servicios))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"089d44685a450ab051e0bab47b023aa630b0b2d8", @"/Views/Servicios/Servicios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"760753f50affd95aefa7174e1ecf0ef27d648c76", @"/Views/_ViewImports.cshtml")]
    public class Views_Servicios_Servicios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Servicios\Servicios.cshtml"
  
    ViewData["Title"] = "Servicios";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(72, 22, true);
            WriteLiteral("<link rel=\"stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 94, "\"", 136, 1);
#line 6 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Servicios\Servicios.cshtml"
WriteAttributeValue("", 101, Url.Content("~/css/servicios.css"), 101, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(137, 210, true);
            WriteLiteral("/>\r\n<div class=\"mx-5 mt-5\">\r\n    <h1 class=\"text-center font-weight-bold\">Servicios</h1>\r\n    <div class=\"d-md-flex  mt-4 justify-content-between\">\r\n        <div class=\"card col col-md-5 p-0\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 347, "\"", 391, 1);
#line 11 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Servicios\Servicios.cshtml"
WriteAttributeValue("", 353, Url.Content("~/img/reparaciones.jpg"), 353, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(392, 531, true);
            WriteLiteral(@" class=""card-img-top"" alt="""">
            <div class=""card-body"">
                <h5 class=""card-title font-weight-bold"">Reparaciones</h5>
                <p class=""card-text"">Reparamos bombas a pistones, paletas y engranaje nacionales e importadas, motores hidráulicos, válvulas y cilindros.
                    Contamos con stock de repuestos y maquinarias para fabricación y recuperación de los mismos.
                </p>
            </div>
        </div>
        <div class=""card col col-md-5 p-0"">
            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 923, "\"", 960, 1);
#line 20 "C:\ProyectoROLO\RVSHidraulica\RVSHidraulica\Views\Servicios\Servicios.cshtml"
WriteAttributeValue("", 929, Url.Content("~/img/foto3.jpg"), 929, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(961, 376, true);
            WriteLiteral(@" class=""card-img-top w-75 mx-auto"" alt="""">
            <div class=""card-body"">
                <h5 class=""card-title font-weight-bold"">Centrales hidráulicas</h5>
                <p class=""card-text"">Construimos y reparamos unidades hidráulicas de acuerdo a las necesidades y requerimientos de nuestros clientes.</p>
            </div>
        </div>
    </div>
</div>
");
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
