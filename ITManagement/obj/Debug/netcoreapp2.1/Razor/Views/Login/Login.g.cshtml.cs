#pragma checksum "C:\Users\VanditJain\Downloads\IT_Managementupdated-main (2)\IT_Managementupdated-main\ITManagement\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6f8d736d290968a769df626f536a1e4859dc001"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Login.cshtml", typeof(AspNetCore.Views_Login_Login))]
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
#line 1 "C:\Users\VanditJain\Downloads\IT_Managementupdated-main (2)\IT_Managementupdated-main\ITManagement\Views\_ViewImports.cshtml"
using ITManagement;

#line default
#line hidden
#line 2 "C:\Users\VanditJain\Downloads\IT_Managementupdated-main (2)\IT_Managementupdated-main\ITManagement\Views\_ViewImports.cshtml"
using ITManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f8d736d290968a769df626f536a1e4859dc001", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a0f013920f1d6b5866185b6f45c2fda83c66d51", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\VanditJain\Downloads\IT_Managementupdated-main (2)\IT_Managementupdated-main\ITManagement\Views\Login\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(39, 11, true);
            WriteLiteral("\n\n\n<html>\n\n");
            EndContext();
            BeginContext(50, 1422, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1252bea710c84ca5abfd302ee7d046ea", async() => {
                BeginContext(56, 1409, true);
                WriteLiteral(@"
    <title>CG Infinity Login</title>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: white;
        }

        .login-container {
            width: 300px;
            margin: 0 auto;
            margin-top: 100px;
            padding: 20px;
            background-color: #fff;
            border: 1px solid #e6e6e6;
            border-radius: 5px;
        }

            .login-container h2 {
                text-align: center;
                margin-bottom: 30px;
            }

        .input-container {
            margin-bottom: 20px;
        }

            .input-container input {
                width: 100%;
                padding: 10px;
                border: 1px solid #ddd;
                border-radius: 5px;
            }

        .login-btn {
            width: 100%;
            padding: 10px;
            background-color: #4CAF50;");
                WriteLiteral(@"
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

            .login-btn:hover {
                background-color: #45a049;
            }

        .logo {
            text-align: center;
        }

            .logo img {
                width: 100px;
                height: 100px;
            }
    </style>
");
                EndContext();
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
            EndContext();
            BeginContext(1472, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(1474, 5688, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a150e2f0c866409bb1a14fd34df2050d", async() => {
                BeginContext(1480, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1485, 5661, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "961b4d5fcbe44d1394c3cd0551f724c5", async() => {
                    BeginContext(1524, 5615, true);
                    WriteLiteral(@"
        <div class=""login-container"">
            <div class=""logo"">
                <img src=""data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxAODw0SDRAOEA8PDw8QDhAQDxAPDxAQFREWFhURExMYHSggGBolGxUVITEhJSkrLi4uFx8zODMsNygtLisBCgoKDg0OGxAQGi0lHyUtLS0tLS0rLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLSstLS0tLS0tLS0tLS0tLf/AABEIAOEA4QMBEQACEQEDEQH/xAAcAAEAAgMBAQEAAAAAAAAAAAAAAQYEBQcCAwj/xABGEAACAQMCAwMHBQwKAwAAAAAAAQIDBBEFEhMhMQYHURQiMkFhcYEVdJGzwQgjNUJSYnWisbK00SU0NnJzkqGkwtIWJDP/xAAaAQEAAgMBAAAAAAAAAAAAAAAAAgMBBAUG/8QAKBEBAAICAgICAQQCAwAAAAAAAAECAxEEEiExBSJBExQyURVCI2Fx/9oADAMBAAIRAxEAPwDuIAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEZAZMbgeeLHxX0lf61N62l1n+nrJZExKKTIZAjJibRHseeLHxX0kJzUj8pdZ/p63E4mJ9Iz4MmRIAAAAAAAAAAAAAAAAAAAAAGJqF7GjByl8F4s1OXyq4K7lZhxTedQq9xe1q8sZlz6Rjk8t");
                    WriteLiteral(@"k5WfkW1TbrVwUxRuU/JVfGeHL6ef7TH7HkxHbyRycXpFtfVaEsZl7YyGLl5+NaO/pm+HHljcLTYXSrQUl8V7T1nGzxmp2cfLjmltPGo30aEcvm3yivFlXM5lcFf+08OGck+FZrXla4ljzn+ZHoveeXvyeRyZ+vp1K4ceKPJ8l18Z2S+0z+y5Otztn9zh9JtdQq0JYy8LrGWehnFzc3HtqWL4ceWPC0WF5GtFSj8V4M9VxeTGenZysuKcdtSyjaVAAAAAAAAAAAAAAAAAAAAQwKjrNw6laSXNRe2K9p435HLbNn6Q7XFpFMfZYdMsI0YJJec1mT9bZ6PhcSuHHH9uZnzTezMwbyhh6jp8a6xLk10kuqNTkcOmb2txZrUnw+i20KfhGCJT042Lwj9sl1VrzndVva3iK8EeTyWvy82vw7FIrgx7Wiwso0YJJLPrfrZ6nicSuGniPLlZss3ncso3N/iVOmFqWnRrrwkuksczQ5XCx548r8Oa2OX0sbONGKjH4v1tlvF49MNesI5ctsltyyzbVAAAAAAAAAAAAAAAAAAAAQyNvQpc3tuG5eqs8/5jxVvry92/t26+cHhc4s9pS0TWNOJMJJCGNx+WFd7RX258OL5LnP+R5r5fl9p/To6nDw6+8sjs9Y7IupJedL0fZE2viuH0r2sq5ubtPWG6O20PwrWsVayrT2Opt83GM46HmPkL8mM309OrxqYpp9mE7i4/Kq/6mjbNy4rtfFMEzp7srurKpSW+bzNcs+os4vJzXy1iZYz4MdKTK4I9jHpxUmQAAAAAAAAAAAAAAAAAAEMCsdobNxnxF6MuvsZ5b5biTW/6lXV4eWJr0ll6TrMWlCq8SXJP1M2vj/kqzHW8qeRxLRO6tv5RDGd0fpR2P3GL32aXS39NXqmsxinGk1Kb5cuiOZzflKUrNaz5beDi2tPlqtJsZV6m6WdieZN/jPwOPweLfPk739NzkZox06VWO/uFRpSl4LEUvE9NyMkYMXhysdZvdrdM1vPm1uT9UvUz");
                    WriteLiteral(@"m8P5at563befiTXzVtnXhjO6GPHKOpObDrt4anS/rTS6vq0XFwpNPPJy9nsOJ8h8hjms0o3uNxrb7WfPs7ZuU+I15sfR9rIfEcSZt+paEubmjXWFmR6hywAAAAAAAAAAAAAAAAAAADA+dWkppqSTT6oryY65I62ZraazuGgvOz7y3Rax+TL+Z53lfDTvtR0cXO8aswfki46bP1lg0v8byYX/usXtmWnZ+Ta4rUV4R5v6Tc4/wANabdrqsvOjWqN/b0I04pRWEj0OLDXFXVXNtebTuXqrSU01JJp9USyY4yV62Yi01ncK/e9n5Jt0WmvyX9h57kfDTveN0sXO/FmF8j1+mz9bkaX+N5W9bXfusTPs9AeU6zWPyY/zN3jfC/btdRl5241VvqVNRSSSSXJI9Fjx1x11DnzabTuX0RNEAAAAAAAAAAAAAAAAAIMf+nsGwMiQIY2BjQgb1IlD8iTIhgQREmfQGQQEgAAAAAAAAAAAAAAAIA1mtqs4x4Gc557euDnc+M01/42xx+kT9mVY71ThxfTS842eN3/AE4i/tVk128MhM2Fachl8L65jSpVakvRpwnUl7oxbZmIYmdOG6JW1jtFWuZ0Lx21Onzit0lCOc7YJR6tLD+JbaIiGvE2mXVfJbulC1hvnUcKcY1J5b3TXpSeThc6OR+rE4/TpYJxxTVvaw0+iz1xz951MfbrG2vPvw95JsIbBtrNbVZxjwM5z523r7Dm/IRmtWP0mxg6b+z6TuJ0rac5LdUp0pyafrcY5wzb4sX6R39qc01i09VX7te21XWFcutRp0uDs27JSlu3Z5vPuNq1dKaX2vGSGlmzIEbgPQAAAAAAAAAAAAAAHOe+zU69rZ2k7WtVoTldqLlSk4trhTeH8UWUiJU5JmGRPUa//i8bji1PKPk6nU4u775v2p7smNfbSUz9VG7G3Ou6rb1KNvdShSjVk6t3WlKVTn0hF9ce4nMRVVWZtDA7R2+r9nq1CpK8nVU23GSnOUJuOG4TjPxJREWhiZtWf");
                    WriteLiteral(@"LoHbyyvtQsra5sbh0KXkcq9xBTlFTjKkp7cJc+WepXXUT5WXiZr4c17vdD1K9hcPTLt20YSgqiVSUNzccp8lz5Fl5hTjrLL7RT1jS7m0o3Wo3E+NKEvMrycdvEUWnle8jHWYT3NbeXRe+TUa1tptOdtVqUZ+VUob6ctsnFwk2m/gQpG5Ty2mI8KpoVlr2tWdHF35NbQg4wnKU+LcSz6c3Hm0SnUI1i1oayx1LU9C1ahbXNxOtTnOkpxc5VKc6dSexSju5xeTOomNo/aJ0uvfdqde1s7SVrWq0Jyu9spU5bW48Go8N+GUiFI2tvbUMbVtP1K+0bSqtrdyptWEat3J1HGVZSopvOFz9ZmJiJYtEzDn/d7ompXiuPky6dsoOnxfvkob21y6dSzJMKsUSuPe1dX2nXNnc29zXjRmoKpSVRum6lN5ecr8aOfoK6xErLTNZdV029hcUKNam1sq041E/ViSyQmPK2J3G3I7TWrvVu0TpW9zXp2dGo3OFOo4wdKjyb6fjT5e4smuoVRabWdoKl4AAAAAAAAAAAAEAcv7/8A+oWfz1fUVSzF7U5vTJqf2Rj+iqf7kR/uT/CXz7h1/R1x87qfsRjL7Zw+mD90Ev8A1rD5xU+rZLGjm9LlQ/AUf0Sv4UhP8k4/go/3Pn/y1D+/R/cJXhDEw++/8J6V/hx+vRnH6RyfyhYu/T8F0vnlD6uZjHP2Ty/xb7uwX9D6f/g/ayF/aWP0513u/h7TF+ZZv/dv/qW0/iqvP3b7v/8A6jY/PV/D1TGP2nl/is3Zv+z1n+iKX8MiM/yT/wBVJ+596ah76P7GSyKsS9d42hLUNNuaaWakI8Wj/fhzx8ehCk6W5I3VzXsn228n0C+pyli4t80rdPGUq3JYX5rcvoLOu52pi2q6WPuM0Hg2dS6mvvl1JKLfXhQ6fS8sjeU8Ufl08qXJMgAAAAAAAAAAAAFF72uzdzqdrb07OMJTp3KqS3S2rbw5x/5EqTpXkrMw+09AuH2eVjtj5T5DCht3ebxFF");
                    WriteLiteral(@"J+d4cjO/ttjrPV57quz1zptnVpXcYxnKvOolGW5bXj1i87lnHEwxe93sxdapQtYWcYSlSqznLfPYsOm0ufvFZ0xenZY6WnVVpStsLiqw4GM8t/B2dfeR35T6/XSr90fZS70uF2ryMIurKm4bJ7sqMcErTtDHXTH7zuyF5qF7Y1bWEJU6MIqblNReeMpcl7sma21DF6bnbcd6PZ641Gwp0bSMZVFcUqjUpbVtjGSfP4mKzqWclNxptuw2m1bPTrOhcJKrSpqM1F7lnL6MjMpUjUKb3h9jb2+1axubaFN0aMLZTcp7X5lxKbwvdInW2o0hem7bbTvZ7N3WqWtrTs4wlOnc8WW+WxbeFOPX3yRis6ZvWZjTf8AZ/TJ0tLtLWtiM6dlTt6jXnJNUtjZGZ8pxE6clsex3aDS61eOm4UKvm8RShslFejJqXNMtm0TCiKWiXbrRz4VPjbVUcIcXHNb8Lcl8SlsRH9vzl2t7Pbdbq2ds0+NcU9kY/icTEpJ+7MmbET4alq7tp+jNMsYW1GjRpJKFKnGEfdFdftKJltVjTKIpJMgAAAAAAAAAAAAEYAYAkCMASY0BkAAEYAkCMASAAqHeFDVXToLRXtqb3xXmmvM28vTT9ZKuvyhft+Ff7uu7+4trqd9qc4zupb9kVLe4yl1qSl445ciVrK6U87l07BUvSZAAAAAAAAAAAAAAAAAAAAAAAAAAAAACACRgSZAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAP/2Q=="" alt=""CG Infinit");
                    WriteLiteral(@"y - Crunchbase Company Profile &amp; Funding"" />
            </div>
            <h2>Login </h2>
            <div class=""input-container"">
                <input type=""text"" placeholder=""Email"" name=""email"" id=""email"" required>
            </div>
            <div class=""input-container"">
                <input type=""password"" placeholder=""Password"" name=""password"" id=""password"" required>
            </div>
            <button class=""login-btn"" type=""submit"">Login</button>
        </div>
    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7146, 9, true);
                WriteLiteral("\n\n      \n");
                EndContext();
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
            EndContext();
            BeginContext(7162, 9, true);
            WriteLiteral("\n\n</html>");
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
