#pragma checksum "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\MisPaginas\DetailsMigrantes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "958714d25af9726bf753842fc35d32aff7d4026a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.MisPaginas.Pages_MisPaginas_DetailsMigrantes), @"mvc.1.0.razor-page", @"/Pages/MisPaginas/DetailsMigrantes.cshtml")]
namespace Frontend.Pages.MisPaginas
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
#line 1 "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"958714d25af9726bf753842fc35d32aff7d4026a", @"/Pages/MisPaginas/DetailsMigrantes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e204b5447433fc29832fde3d015c2ce34c8ad9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MisPaginas_DetailsMigrantes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Agroquimicos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h2>DATOS MIGRANTES</h2>\r\n\r\n<div>\r\n    nombre: ");
#nullable restore
#line 8 "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\MisPaginas\DetailsMigrantes.cshtml"
       Write(Model.Migrantes.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    apellidos: ");
#nullable restore
#line 11 "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\MisPaginas\DetailsMigrantes.cshtml"
          Write(Model.Migrantes.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    tipo_documento: ");
#nullable restore
#line 14 "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\MisPaginas\DetailsMigrantes.cshtml"
               Write(Model.Migrantes.tipo_documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    numero_documento: ");
#nullable restore
#line 17 "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\MisPaginas\DetailsMigrantes.cshtml"
                 Write(Model.Migrantes.numero_documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    pais : ");
#nullable restore
#line 20 "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\MisPaginas\DetailsMigrantes.cshtml"
      Write(Model.Migrantes.pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    fecha_nacimiento : ");
#nullable restore
#line 23 "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\MisPaginas\DetailsMigrantes.cshtml"
                  Write(Model.Migrantes.fecha_nacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    correo : ");
#nullable restore
#line 26 "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\MisPaginas\DetailsMigrantes.cshtml"
        Write(Model.Migrantes.correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    telefono : ");
#nullable restore
#line 29 "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\MisPaginas\DetailsMigrantes.cshtml"
          Write(Model.Migrantes.telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    direccion : ");
#nullable restore
#line 32 "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\MisPaginas\DetailsMigrantes.cshtml"
           Write(Model.Migrantes.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ciudad  : ");
#nullable restore
#line 35 "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\MisPaginas\DetailsMigrantes.cshtml"
         Write(Model.Migrantes.ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    situacion_laboral  : ");
#nullable restore
#line 38 "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\MisPaginas\DetailsMigrantes.cshtml"
                    Write(Model.Migrantes.situacion_laboral);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    contraseña: ");
#nullable restore
#line 40 "C:\Users\andresfelipe\Documents\GitHub\e-migrant-grupo1_cenit\frontend\Pages\MisPaginas\DetailsMigrantes.cshtml"
           Write(Model.Migrantes.contraseña);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "958714d25af9726bf753842fc35d32aff7d4026a7447", async() => {
                WriteLiteral("Volver ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend.Pages.DetailsMigrantesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.DetailsMigrantesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.DetailsMigrantesModel>)PageContext?.ViewData;
        public Frontend.Pages.DetailsMigrantesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591