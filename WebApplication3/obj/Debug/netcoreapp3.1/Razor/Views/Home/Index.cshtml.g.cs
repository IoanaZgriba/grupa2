#pragma checksum "C:\Users\ioana.zgriba\source\repos\IoanaZgriba\grupa2\WebApplication3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "067119b950755d8e26fbdff710591e6ef8df7c91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ioana.zgriba\source\repos\IoanaZgriba\grupa2\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ioana.zgriba\source\repos\IoanaZgriba\grupa2\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"067119b950755d8e26fbdff710591e6ef8df7c91", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ioana.zgriba\source\repos\IoanaZgriba\grupa2\WebApplication3\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "067119b950755d8e26fbdff710591e6ef8df7c913524", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width"" />
    <title>UVT Smart Management In Dorms</title>
    <link rel=""stylesheet"" href=""css/styles.css"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-circle-progress/1.2.2/circle-progress.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "067119b950755d8e26fbdff710591e6ef8df7c914910", async() => {
                WriteLiteral(@"

    <header class=""page-header gradient"">
        <div class=""container pt-3"">
            <div class=""row align-items-center justify-content-center"">
                <div class=""col-md-5"">
                    <h2>UVT Smart Management In Dorms</h2>

                    <p>
                        UVT ofer?? studen??ilor s??i 300 locuri de cazare ??n cele 3 c??mine
                        diferite (ele fiind situate ??n Complexul Studen??esc),
                        fiecare av??nd diverse dot??ri.
                    </p>

                    <button type=""button"" class=""btn btn-outline-success btn-lg"">
                        Afla mai multe
                    </button>
                </div>
                <div class=""col-md-5"">
                    <img src=""img/email_campaign_monochromatic.svg""
                         alt=""Header image"" />
                </div>
            </div>
        </div>
        <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 1440 250"">
            <path fi");
                WriteLiteral(@"ll=""#fff""
                  fill-opacity=""1""
                  d=""M0,128L48,117.3C96,107,192,85,288,80C384,75,480,85,576,112C672,139,768,181,864,181.3C960,181,1056,139,1152,122.7C1248,107,1344,117,1392,122.7L1440,128L1440,320L1392,320C1344,320,1248,320,1152,320C1056,320,960,320,864,320C768,320,672,320,576,320C480,320,384,320,288,320C192,320,96,320,48,320L0,320Z""></path>
        </svg>
    </header>

    <section class=""feature gradient"">
        <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 1440 320"">
            <path fill=""#fff""
                  fill-opacity=""1""
                  d=""M0,224L48,213.3C96,203,192,181,288,154.7C384,128,480,96,576,117.3C672,139,768,213,864,208C960,203,1056,117,1152,101.3C1248,85,1344,139,1392,165.3L1440,192L1440,0L1392,0C1344,0,1248,0,1152,0C1056,0,960,0,864,0C768,0,672,0,576,0C480,0,384,0,288,0C192,0,96,0,48,0L0,0Z""></path>
        </svg>
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-md-6"">");
                WriteLiteral("\n                    <img src=\"img/seo_monochromatic.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 2617, "\"", 2623, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                </div>

                <div class=""col-md-6"">
                    <h1 class=""my-3"">Ce Oferim</h1>
                    <p class=""my-4"">
                        UVT ofer?? studen??ilor s??i 300 locuri de cazare ??n 3 c??mine diferite
                        (ele fiind situate ??n Complexul Studen??esc).
                    </p>
                    <p class=""my-4"">
                        Completand formularul de mai jos, va puteti completa cererea de a fi
                        repartizat in unul din locurile de cazare.
                    </p>
                    <p class=""my-4"">
                        Lista cu cuantumurile taxelor lunare de cazare pentru un loc de cazare
                        ??n c??minele UVT este disponibil?? <span><a href=""https://drive.google.com/file/d/1j65HL7F37J7I1xE_Rpj2-KeNUkuBgpIm/view?usp=sharing"" target=""_blank"" rel=""noopener""><span style=""font-weight: 600"" />AICI</a></span>.
                    </p>
                    <ul>
                       ");
                WriteLiteral(@" <li>Caminul 3 (5 persoane)</li>
                        <li>Caminul 4 (2 persoane)</li>
                        <li>Caminul 7 (3 persoane)</li>
                    </ul>
                </div>
            </div>
        </div>
        <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 1440 320"">
            <path fill=""#fff""
                  fill-opacity=""1""
                  d=""M0,224L48,213.3C96,203,192,181,288,154.7C384,128,480,96,576,117.3C672,139,768,213,864,208C960,203,1056,117,1152,101.3C1248,85,1344,139,1392,165.3L1440,192L1440,320L1392,320C1344,320,1248,320,1152,320C1056,320,960,320,864,320C768,320,672,320,576,320C480,320,384,320,288,320C192,320,96,320,48,320L0,320Z""></path>
        </svg>
    </section>
    <section class=""companies"">
        <p style=""font-weight:600;font-size:20px;margin-top:13px;font-family:'Montserrat', sans-serif;""></p>
        <div class=""container text-center"">
            <h1>Facilitati</h1>
            <div class=""row g-5"">
                <div class=""");
                WriteLiteral(@"col-md-2"">
                    <img src=""img/companies/internet.png""
                         alt=""Company logo""
                         class=""img-fluid"" />
                    <p style=""font-weight:600;font-size:12px;margin-top:13px;text-transform:uppercase"">Internet</p>
                </div>
                <div class=""col-md-2"">
                    <img src=""img/companies/tv.png""
                         alt=""Company logo""
                         class=""img-fluid"" />
                    <p style=""font-weight:600;font-size:12px;margin-top:13px;text-transform:uppercase"">Cablu TV</p>
                </div>
                <div class=""col-md-2"">
                    <img src=""img/companies/baie.png""
                         alt=""Company logo""
                         class=""img-fluid"" />
                    <p style=""font-weight:600;font-size:12px;margin-top:13px;text-transform:uppercase"">Baie Proprie</p>
                </div>
                <div class=""col-md-2"">
                    <i");
                WriteLiteral(@"mg src=""img/companies/bucatarie.png""
                         alt=""Company logo""
                         class=""img-fluid"" />
                    <p style=""font-weight:600;font-size:12px;margin-top:13px;text-transform:uppercase"">Bucatarie Proprie</p>
                </div>
                <div class=""col-md-2"">
                    <img src=""img/companies/masina de spalat.png""
                         alt=""Company logo""
                         class=""img-fluid"" />
                    <p style=""font-weight:600;font-size:12px;margin-top:13px;text-transform:uppercase"">Masina de Spalat</p>
                </div>
                <div class=""col-md-2"">
                    <img src=""img/companies/sala.png""
                         alt=""Company logo""
                         class=""img-fluid"" />
                    <p style=""font-weight:600;font-size:12px;margin-top:13px;text-transform:uppercase"">Sala de Lectura</p>
                </div>
            </div>
        </div>
    </section>

    <se");
                WriteLiteral(@"ction class=""gallery"">
        <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 1440 160"">
            <path fill=""#fff""
                  fill-opacity=""1""
                  d=""M0,128L120,128C240,128,480,128,720,122.7C960,117,1200,107,1320,101.3L1440,96L1440,0L1320,0C1200,0,960,0,720,0C480,0,240,0,120,0L0,0Z""></path>
        </svg>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-10"">
                    <h1>Galerie</h1>
                    <p>

                    </p>
                </div>
            </div>
            <div class=""row my-3 g-3"">
                <div class=""col-md-4"">
                    <img src=""img/cam4.jpg"" alt=""Gallery image"" class=""img-fluid"" />
                </div>
                <div class=""col-md-4"">
                    <img src=""img/cam2.jpg"" alt=""Gallery image"" class=""img-fluid"" />
                </div>
                <div class=""col-md-4"">
                    <img src=""img/cam8.jpg"" alt=""Gallery ima");
                WriteLiteral(@"ge"" class=""img-fluid"" />
                </div>
            </div>
        </div>
        <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 1440 320"">
            <path fill=""#fff""
                  fill-opacity=""1""
                  d=""M0,128L120,128C240,128,480,128,720,122.7C960,117,1200,107,1320,101.3L1440,96L1440,320L1320,320C1200,320,960,320,720,320C480,320,240,320,120,320L0,320Z""></path>
        </svg>
    </section>

    <section class=""services gradient"">
        <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 1440 220"">
            <path fill=""#fff""
                  fill-opacity=""1""
                  d=""M0,96L34.3,106.7C68.6,117,137,139,206,122.7C274.3,107,343,53,411,53.3C480,53,549,107,617,117.3C685.7,128,754,96,823,96C891.4,96,960,128,1029,154.7C1097.1,181,1166,203,1234,202.7C1302.9,203,1371,181,1406,170.7L1440,160L1440,0L1405.7,0C1371.4,0,1303,0,1234,0C1165.7,0,1097,0,1029,0C960,0,891,0,823,0C754.3,0,686,0,617,0C548.6,0,480,0,411,0C342.9,0,274,0,206,0C137.1,0,69,0,34,0L0,0Z");
                WriteLiteral(@"""></path>
        </svg>

        <h1>Grad Ocupare Camine</h1>
        <div class=""wrapper"">
            <div class=""card"">
                <div class=""circle"">
                    <div class=""bar""></div>
                    <div class=""box""><span></span></div>
                </div>
                <div class=""text"">Caminul 3</div>
            </div>
            <div class=""card js"">
                <div class=""circle"">
                    <div class=""bar""></div>
                    <div class=""box""><span></span></div>
                </div>
                <div class=""text"">Caminul 4</div>
            </div>
            <div class=""card react"">
                <div class=""circle"">
                    <div class=""bar""></div>
                    <div class=""box""><span></span></div>
                </div>
                <div class=""text"">Caminul 7</div>
            </div>
        </div>


        <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 1440 210"">
            <path fi");
                WriteLiteral(@"ll=""#fff""
                  fill-opacity=""1""
                  d=""M0,96L34.3,106.7C68.6,117,137,139,206,122.7C274.3,107,343,53,411,53.3C480,53,549,107,617,117.3C685.7,128,754,96,823,96C891.4,96,960,128,1029,154.7C1097.1,181,1166,203,1234,202.7C1302.9,203,1371,181,1406,170.7L1440,160L1440,320L1405.7,320C1371.4,320,1303,320,1234,320C1165.7,320,1097,320,1029,320C960,320,891,320,823,320C754.3,320,686,320,617,320C548.6,320,480,320,411,320C342.9,320,274,320,206,320C137.1,320,69,320,34,320L0,320Z""></path>
        </svg>
    </section>

    <section class=""contact"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-5"">
                    <h1>Contacteaza-ne:</h1>
                    <div class=""mb-3"">
                        <label for=""exampleFormControlInput1"" class=""form-label"">Adresa e-mail :</label>
                        <input type=""email""
                               class=""form-control""
                               id=""exampleFormControlInput");
                WriteLiteral(@"1""
                               placeholder=""nume@exemplu.com"" />
                    </div>
                    <div class=""mb-3"">
                        <label for=""exampleFormControlTextarea1"" class=""form-label"">Mesaj :</label>
                        <textarea class=""form-control""
                                  id=""exampleFormControlTextarea1""
                                  rows=""3""
                                  placeholder=""Introduceti un mesaj ...""></textarea>
                    </div>
                    <button type=""button"" class=""btn btn-outline-secondary"">
                        Send
                    </button>
                </div>
                <div class=""col-md-5"">
                    <img src=""img/handshake.svg"" alt=""Contact image"" />
                </div>
            </div>
        </div>
    </section>








    <footer class=""gradient"">
        <div class=""container-fluid text-center"">
            <span>
                ! VA PWP !
     ");
                WriteLiteral(@"       </span>
        </div>
    </footer>
    <script src=""js/bootstrap.min.js""></script>

    <script>
        let options = {
            startAngle: -1.55,
            size: 150,
            value: 0.33,
            fill: { gradient: ['#ffba08', '#ffd166'] }
        }
        $("".circle .bar"").circleProgress(options).on('circle-animation-progress',
            function (event, progress, stepValue) {
                $(this).parent().find(""span"").text(String(stepValue.toFixed(2).substr(2)) + ""%"");
            });
        $("".js .bar"").circleProgress({
            value: 0.46
        });
        $("".react .bar"").circleProgress({
            value: 0.83
        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
