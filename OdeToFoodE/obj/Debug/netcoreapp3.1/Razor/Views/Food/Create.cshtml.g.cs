#pragma checksum "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "448281fa7e89eebead2b737c2360b45e6cb9a622"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Create), @"mvc.1.0.view", @"/Views/Food/Create.cshtml")]
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
#line 1 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\_ViewImports.cshtml"
using OdeToFoodE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\_ViewImports.cshtml"
using OdeToFoodE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"448281fa7e89eebead2b737c2360b45e6cb9a622", @"/Views/Food/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a07e5231645316ad9a6a0ddea6d9b6ec2234f04b", @"/Views/_ViewImports.cshtml")]
    public class Views_Food_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\" style=\"background-image: url(\'//ima/30.png\')\">\r\n        <h4>Food</h4>\r\n         <p>\r\n            ");
#nullable restore
#line 17 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
       Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <hr />\r\n        ");
#nullable restore
#line 20 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 22 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
       Write(Html.LabelFor(model => model.FoodId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 24 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
           Write(Html.EditorFor(model => model.FoodId, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 25 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.FoodId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 30 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
       Write(Html.LabelFor(model => model.FoodName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 32 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
           Write(Html.EditorFor(model => model.FoodName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 33 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.FoodName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 38 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
       Write(Html.LabelFor(model => model.FoodDescription, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 40 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
           Write(Html.EditorFor(model => model.FoodDescription, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 41 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.FoodDescription, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        \r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 46 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
       Write(Html.LabelFor(model => model.CuisineName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n               \r\n                ");
#nullable restore
#line 49 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
           Write(Html.EditorFor(model => model.CuisineName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 50 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.CuisineName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        \r\n        <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 55 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
               Write(Html.LabelFor(model => model.Price, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 57 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
                   Write(Html.EditorFor(model => model.Price, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 58 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
        

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Create"" class=""btn btn-success"" />
            </div>
        </div>
        
        
           
            
          
    </div>
");
#nullable restore
#line 74 "C:\Users\EMMY PIANO\Desktop\OdeToFoodE\OdeToFoodE\Views\Food\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
