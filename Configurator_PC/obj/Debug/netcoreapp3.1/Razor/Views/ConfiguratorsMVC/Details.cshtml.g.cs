#pragma checksum "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00e6723c3d494aa9855f83b611c2914b3b415039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ConfiguratorsMVC_Details), @"mvc.1.0.view", @"/Views/ConfiguratorsMVC/Details.cshtml")]
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
#line 1 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\_ViewImports.cshtml"
using Configurator_PC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\_ViewImports.cshtml"
using Configurator_PC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00e6723c3d494aa9855f83b611c2914b3b415039", @"/Views/ConfiguratorsMVC/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0441a38b5044dc16f66c78db1b1920dd360a0966", @"/Views/_ViewImports.cshtml")]
    public class Views_ConfiguratorsMVC_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Configurator_PC.Models.Configurator>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Configurator</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Processor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayFor(model => model.Processor.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VideoCard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayFor(model => model.VideoCard.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Motherboard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayFor(model => model.Motherboard.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cooling));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cooling.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RAM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayFor(model => model.RAM.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SSD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayFor(model => model.SSD.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HardDrive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayFor(model => model.HardDrive.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PowerSupply));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayFor(model => model.PowerSupply.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SoundCard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayFor(model => model.SoundCard.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NetworkAdapter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
       Write(Html.DisplayFor(model => model.NetworkAdapter.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00e6723c3d494aa9855f83b611c2914b3b41503911776", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 82 "C:\Users\FCZ\source\repos\Configurator_PC(MVC)\Configurator_PC\Views\ConfiguratorsMVC\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00e6723c3d494aa9855f83b611c2914b3b41503913940", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Configurator_PC.Models.Configurator> Html { get; private set; }
    }
}
#pragma warning restore 1591
