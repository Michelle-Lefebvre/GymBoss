#pragma checksum "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "704369bd38f9aa3414f55b4821aeb1e0b9c05e2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GymTrain.Pages.Pages_Details), @"mvc.1.0.razor-page", @"/Pages/Details.cshtml")]
namespace GymTrain.Pages
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
#line 1 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/_ViewImports.cshtml"
using GymTrain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"704369bd38f9aa3414f55b4821aeb1e0b9c05e2a", @"/Pages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9721af27b8e38658f79df81e062fe67436c5ff62", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("friend-image img-fluid img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("but btn-sm float-right mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container friendInfo\">\r\n        <div id=\"friendsWrapper\" class=\"row\">\r\n            <div class=\"col-sm-4 mt-3 mb-3 \">\r\n                <div>\r\n                    <h3 class=\"pt-3 pb-3\">");
#nullable restore
#line 9 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
                                     Write(Html.DisplayFor(model => model.Trainer.FirstMidName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
                                                                                           Write(Html.DisplayFor(model => model.Trainer.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "704369bd38f9aa3414f55b4821aeb1e0b9c05e2a4840", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 455, "~/Images/", 455, 9, true);
#nullable restore
#line 11 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
AddHtmlAttributeValue("", 464, Html.DisplayFor(model => model.Trainer.Image), 464, 46, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 542, "Image", 542, 5, true);
            AddHtmlAttributeValue(" ", 547, "of", 548, 3, true);
#nullable restore
#line 12 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
AddHtmlAttributeValue(" ", 550, Html.DisplayFor(model => model.Trainer.FirstMidName), 551, 53, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"action p-2\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "704369bd38f9aa3414f55b4821aeb1e0b9c05e2a7107", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-8 mt-5 mb-3\">\r\n                <dl class=\"row\">\r\n                    <dt class=\"col-sm-2 mt-3\">\r\n                        ");
#nullable restore
#line 21 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Trainer.Certified));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10 mt-3\">\r\n                        ");
#nullable restore
#line 24 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
                   Write(Html.DisplayFor(model => model.Trainer.Certified));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 27 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Trainer.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 30 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
                   Write(Html.DisplayFor(model => model.Trainer.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 33 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Trainer.Specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 36 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
                   Write(Html.DisplayFor(model => model.Trainer.Specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dd class=\"col-sm-12\">\r\n                        ");
#nullable restore
#line 39 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
                   Write(Html.DisplayFor(model => model.Trainer.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </dd>
                </dl>
            </div>
    
            <div class=""row center ml-3 mr-3 mb-3"">
                <div class=""col-sm-12 col-md-4"">
                    <div class=""card text-center"">
                        <div class=""card-body"">
                            <small>5 Prepaid Sessions</small>
                            <p class=""display-3""><small>$</small>");
#nullable restore
#line 49 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.Trainer.Pkg5));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <small>per</small><br>session</span></p>
                            <small class=""mbr-plan-price-desc"">5 individual personal training sessions</small>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-12 col-md-4"">
                    <div class=""card text-center"">
                        <div class=""card-body"">
                            <small>12 Prepaid Sessions</small>
                            <p class=""display-3""><small>$</small>");
#nullable restore
#line 59 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.Trainer.Pkg12));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <small>per</small><br>session</span></p>
                            <small class=""mbr-plan-price-desc"">12 individual personal training sessions</small>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-12 col-md-4"">
                    <div class=""card text-center"">
                        <div class=""card-body"">
                            <small>20 Prepaid Sessions</small>
                            <p class=""display-3""><small>$</small>");
#nullable restore
#line 69 "/Users/michellelefebvre/IPD21-ASP-Project/GymTrain/Pages/Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.Trainer.Pkg20));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <small>per</small><br>session</span></p>
                            <small class=""mbr-plan-price-desc"">20 individual personal training sessions</small>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymTrain.Pages.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GymTrain.Pages.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GymTrain.Pages.DetailsModel>)PageContext?.ViewData;
        public GymTrain.Pages.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591