#pragma checksum "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3477628fe7129ecff67fb3676dec6fb49446573b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Car_Cost_Calculator.Pages.Pages_CostOverview), @"mvc.1.0.razor-page", @"/Pages/CostOverview.cshtml")]
namespace Car_Cost_Calculator.Pages
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
#line 1 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\_ViewImports.cshtml"
using Car_Cost_Calculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\_ViewImports.cshtml"
using Car_Cost_Calculator.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3477628fe7129ecff67fb3676dec6fb49446573b", @"/Pages/CostOverview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e4615964a468d42b7524e2820308449580a6588", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CostOverview : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Navigation.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" width: 75px; height: 105px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/CarCostNavLogo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3477628fe7129ecff67fb3676dec6fb49446573b5430", async() => {
                WriteLiteral("\r\n    <title>Bootstrap Example</title>\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3477628fe7129ecff67fb3676dec6fb49446573b5844", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3477628fe7129ecff67fb3676dec6fb49446573b8120", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"container-fluid text-center\">\r\n        <div class=\"row content\">\r\n            <div class=\"col-sm-2 sidenav\">\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3477628fe7129ecff67fb3676dec6fb49446573b8548", async() => {
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
                WriteLiteral(@"


<!--verander axis, horizontaal naar digitaal vice versa-->
<!--ipv 1 kolom naar 2 kolommen-->
<!--foreach loop met de data en tel op in totaal-->
<!-- verschillende kosten naar 1 kost brengen, behalve brandstofkosten-->
<!--creeer functie waarbij je foreach loop doet tussen bepaalde datums in-->
            </div>
            <div class=""col-sm-8 text-left"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"">Voertuig:</th>
                            <th scope=""col"">Kenteken:</th>
                            <th scope=""col"">Prijs (bij aanschaf):</th>
                            <th scope=""col"">Tank Kosten:</th>
                            <th scope=""col"">Overige Kosten:</th>
                            <th scope=""col"">Totaal:</th>
                        </tr>
                    </thead>

                    <tbody>
");
#nullable restore
#line 48 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml"
                         foreach (var vehicle in Model.vehicles)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 51 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml"
                               Write(vehicle.Vehicle_Kind);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 52 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml"
                               Write(vehicle.Number_Plate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml"
                               Write(vehicle.BuyCost);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 54 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml"
                                 foreach (var tank in Model.tanks)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>");
#nullable restore
#line 56 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml"
                                   Write(tank.Tank_Cost);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 57 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml"
                                 foreach (var cost in Model.cost)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>");
#nullable restore
#line 60 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml"
                                   Write(cost.Cost_Amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 61 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 63 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml"
                         foreach (var cost in Model.Info)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\C# code\Car-Cost-Carculator\Car Cost Calculator\Pages\CostOverview.cshtml"
                                   
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </tbody>

                </table>



            </div>
            <div class=""col-sm-2 sidenav"">
                
                <p>Handige Links:</p>
                <p><a href=""/Index"">Home</a></p>
                <p><a href=""/CostInput"">Kosten invoeren</a></p>
                <p><a href=""#"">Uitloggen</a></p>



            </div>
        </div>
    </div>




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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car_Cost_Calculator.Pages.CostOverviewModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Car_Cost_Calculator.Pages.CostOverviewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Car_Cost_Calculator.Pages.CostOverviewModel>)PageContext?.ViewData;
        public Car_Cost_Calculator.Pages.CostOverviewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
