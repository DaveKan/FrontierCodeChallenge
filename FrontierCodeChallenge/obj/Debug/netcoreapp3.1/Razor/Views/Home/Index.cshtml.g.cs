#pragma checksum "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd2f9c4576a9ecc341bbb67816f82968784b9617"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd2f9c4576a9ecc341bbb67816f82968784b9617", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrontierCodeChallenge.Models.AccountsViewModel>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd2f9c4576a9ecc341bbb67816f82968784b96173032", async() => {
                WriteLiteral(@"
    <title>Accounts Coding Test</title>
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.min.css"">
    <style>
        html, body {
            height: 100%;
            width: 100%;
            font-family: Roboto, Helvetica, Arial, sans-serif
        }

        article {
            height: 100%;
            grid-template-columns: 1fr;
            grid-template-areas: ""header"" ""main"" ""footer"";
            grid-template-rows: 100px 1fr 150px;
        }

        header {
            grid-area: header;
            background-color: #006643;
            color: #fff;
            grid-template-columns: 1% 98% 1%;
        }

        h1 {
            font-size: 3em;
            font-weight: bold;
        }

        h2 {
            font-size: 2em;
            color: #006643;
        }

        h3 {
            display: block;
            font-size: 1.5em;
            color: #006643;
        }

        main {
     ");
                WriteLiteral(@"       grid-area: main;
        }

        footer {
            grid-area: footer;
            background-color: #006643;
            color: #fff;
            grid-template-columns: 1% 98% 1%;
            grid-template-rows: 5% 90% 5%;
        }

        .grid {
            display: grid;
        }

        .title-container {
            grid-column-start: 2;
            align-self: center;
        }

        #home-content {
            grid-row-gap: 25px;
            grid-template-rows: 10px 100px auto;
        }

        #account-grid {
            grid-template-columns: 1fr 1fr 1fr;
            grid-row-start: 3;
        }

        .account-column {
            grid-template-rows: 2em repeat(2, 10em);
        }

        .content-title-container {
            justify-self: center;
            height: 1em;
            grid-row-start: 2;
        }

        #overdue-account-container-title > h3 {
            color: #B22222;
        }

        #inactive-account-contai");
                WriteLiteral(@"ner-title > h3 {
            color: #808080;
        }

        .account-container {
            justify-self: center;
            height: 5em;
        }

        .account-container-title {
            justify-self: center;
        }

        .account-data-list {
            list-style: none;
        }

            .account-data-list > li {
                margin: 10px 0;
            }

                .account-data-list > li > label {
                    font-weight: bold;
                    margin: 0 5px 0 0;
                }

        .copy {
            place-self: end;
            grid-row-start: 2;
            grid-column-start: 2;
        }
    </style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd2f9c4576a9ecc341bbb67816f82968784b96176829", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"
        <header class=""grid"">
            <div class=""title-container"">
                <h1>Coding Test</h1>
            </div>
        </header>
        <main class=""content grid"" id=""home-content"">
            <div class=""content-title-container"">
                <h2>Accounts</h2>
            </div>
            <section class=""grid"" id=""account-grid"">
                <section class=""account-column grid"" id=""active-account-column"">
                    <div class=""account-container-title"" id=""active-account-container-title"">
                        <h3>Active</h3>
                    </div>
                    <div class=""account-container active-account"">
");
#nullable restore
#line 148 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {
                            if (item.AccountStatusId == 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <ul class=\"account-data-list\">\r\n                                    <li>Name: ");
#nullable restore
#line 153 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                         Write(Html.DisplayFor(model => item.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 153 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                                                                   Write(Html.DisplayFor(model => item.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li>Email: ");
#nullable restore
#line 154 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li>Phone Number: ");
#nullable restore
#line 155 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.PhoneNum));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li>Amount Due: ");
#nullable restore
#line 156 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.AmountDue));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li>Due Date: ");
#nullable restore
#line 157 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.PaymentDueDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li><hr /></li>\r\n                                </ul>\r\n");
#nullable restore
#line 160 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </section>
                <br /><br />
                <section class=""account-column grid"" id=""overdue-account-column"">
                    <div class=""account-container-title"" id=""overdue-account-container-title"">
                        <h3>Overdue</h3>
                    </div>
                    <div class=""account-container overdue-account"">
");
#nullable restore
#line 170 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {
                            if (item.AccountStatusId == 2)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <ul class=\"account-data-list\">\r\n                                    <li>Name: ");
#nullable restore
#line 175 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                         Write(Html.DisplayFor(model => item.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 175 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                                                                   Write(Html.DisplayFor(model => item.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li>Email: ");
#nullable restore
#line 176 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li>Phone Number: ");
#nullable restore
#line 177 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.PhoneNum));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li>Amount Due: ");
#nullable restore
#line 178 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.AmountDue));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li>Due Date: ");
#nullable restore
#line 179 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.PaymentDueDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li><hr /></li>\r\n                                </ul>\r\n");
#nullable restore
#line 182 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </section>
                <br /><br />
                <section>
                <div class=""account-column grid"" id=""inactive-account-column"">
                    <div class=""account-container-title"" id=""inactive-account-container-title"">
                        <h3>Inactive</h3>
                    </div>
                    <div class=""account-container inactive-account"">
");
#nullable restore
#line 193 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {
                            if (item.AccountStatusId == 1)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <ul class=\"account-data-list\">\r\n                                    <li>Name: ");
#nullable restore
#line 198 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                         Write(Html.DisplayFor(model => item.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 198 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                                                                   Write(Html.DisplayFor(model => item.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li>Email: ");
#nullable restore
#line 199 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li>Phone Number: ");
#nullable restore
#line 200 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.PhoneNum));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li>Amount Due: ");
#nullable restore
#line 201 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.AmountDue));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li><hr /></li>\r\n                                </ul>\r\n");
#nullable restore
#line 204 "D:\Users\DaveKan\Documents\VS-Source\FrontierCodeChallenge\FrontierCodeChallenge\Views\Home\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </section>
            <br /><br />
            </section>
        </main>
        <footer class=""grid"">
            <p class=""copy"">&copy;
            <script>document.write(new Date().getFullYear())</script></p>
        </footer>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrontierCodeChallenge.Models.AccountsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
