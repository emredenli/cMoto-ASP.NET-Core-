#pragma checksum "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a17f3b1a38520110b0bb86cfff9fbe6b157bfd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engines_Details), @"mvc.1.0.view", @"/Views/Engines/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Engines/Details.cshtml", typeof(AspNetCore.Views_Engines_Details))]
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
#line 1 "D:\Project\cMoto\motocycleApp\Views\_ViewImports.cshtml"
using motocycleApp;

#line default
#line hidden
#line 2 "D:\Project\cMoto\motocycleApp\Views\_ViewImports.cshtml"
using motocycleApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a17f3b1a38520110b0bb86cfff9fbe6b157bfd8", @"/Views/Engines/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eed810ea4b8e7bdce92e18e1bd4b8cc4f869ca4", @"/Views/_ViewImports.cshtml")]
    public class Views_Engines_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<motocycle.Data.Model.Engine>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(81, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Engine</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(202, 45, false);
#line 14 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VehicleId));

#line default
#line hidden
            EndContext();
            BeginContext(247, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(291, 41, false);
#line 17 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayFor(model => model.VehicleId));

#line default
#line hidden
            EndContext();
            BeginContext(332, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(376, 46, false);
#line 20 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EngineType));

#line default
#line hidden
            EndContext();
            BeginContext(422, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(466, 42, false);
#line 23 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayFor(model => model.EngineType));

#line default
#line hidden
            EndContext();
            BeginContext(508, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(552, 50, false);
#line 26 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EngineCapacity));

#line default
#line hidden
            EndContext();
            BeginContext(602, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(646, 46, false);
#line 29 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayFor(model => model.EngineCapacity));

#line default
#line hidden
            EndContext();
            BeginContext(692, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(736, 52, false);
#line 32 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CylinderDiameter));

#line default
#line hidden
            EndContext();
            BeginContext(788, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(832, 48, false);
#line 35 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayFor(model => model.CylinderDiameter));

#line default
#line hidden
            EndContext();
            BeginContext(880, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(924, 41, false);
#line 38 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Strok));

#line default
#line hidden
            EndContext();
            BeginContext(965, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1009, 37, false);
#line 41 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayFor(model => model.Strok));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1090, 51, false);
#line 44 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompressionRate));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1185, 47, false);
#line 47 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompressionRate));

#line default
#line hidden
            EndContext();
            BeginContext(1232, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1276, 46, false);
#line 50 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FuelSystem));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1366, 42, false);
#line 53 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayFor(model => model.FuelSystem));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1452, 48, false);
#line 56 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaximumPower));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1544, 44, false);
#line 59 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaximumPower));

#line default
#line hidden
            EndContext();
            BeginContext(1588, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1632, 49, false);
#line 62 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.maximumTorque));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1725, 45, false);
#line 65 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayFor(model => model.maximumTorque));

#line default
#line hidden
            EndContext();
            BeginContext(1770, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1814, 44, false);
#line 68 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ignition));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1902, 40, false);
#line 71 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ignition));

#line default
#line hidden
            EndContext();
            BeginContext(1942, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1986, 48, false);
#line 74 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Transmission));

#line default
#line hidden
            EndContext();
            BeginContext(2034, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2078, 44, false);
#line 77 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayFor(model => model.Transmission));

#line default
#line hidden
            EndContext();
            BeginContext(2122, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2166, 53, false);
#line 80 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PowerTransmission));

#line default
#line hidden
            EndContext();
            BeginContext(2219, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2263, 49, false);
#line 83 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
       Write(Html.DisplayFor(model => model.PowerTransmission));

#line default
#line hidden
            EndContext();
            BeginContext(2312, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2359, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a17f3b1a38520110b0bb86cfff9fbe6b157bfd813457", async() => {
                BeginContext(2405, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "D:\Project\cMoto\motocycleApp\Views\Engines\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2413, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2421, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a17f3b1a38520110b0bb86cfff9fbe6b157bfd815758", async() => {
                BeginContext(2443, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2459, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<motocycle.Data.Model.Engine> Html { get; private set; }
    }
}
#pragma warning restore 1591