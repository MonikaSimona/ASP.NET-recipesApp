#pragma checksum "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f2daa179cc8c2b3200d60181889e95698253930"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredients_Details), @"mvc.1.0.view", @"/Views/Ingredients/Details.cshtml")]
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
#line 1 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\_ViewImports.cshtml"
using HealthyRecipes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\_ViewImports.cshtml"
using HealthyRecipes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f2daa179cc8c2b3200d60181889e95698253930", @"/Views/Ingredients/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e92e966990f985a27ec100de31e230807687e615", @"/Views/_ViewImports.cshtml")]
    public class Views_Ingredients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthyRecipes.Models.Ingredient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <h2>");
#nullable restore
#line 10 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
   
    <hr />
    <dl class=""row"">
        <dt class = ""col-sm-2"">
            
        </dt>
        <dd class = ""col-sm-10"">
            
        </dd>
        <dt class = ""col-sm-2"">
           
        </dt>
        <dd class = ""col-sm-10"">
            <img");
            BeginWriteAttribute("src", " src=\"", 426, "\"", 473, 1);
#nullable restore
#line 24 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
WriteAttributeValue("", 432, Html.DisplayFor(model => model.ImageUrl), 432, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"250\" />\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CaloriesPerItem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
       Write(Html.DisplayFor(model => model.CaloriesPerItem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProteinsPerItem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProteinsPerItem));

#line default
#line hidden
#nullable disable
            WriteLiteral(" grams\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SugarPerItem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
       Write(Html.DisplayFor(model => model.SugarPerItem));

#line default
#line hidden
#nullable disable
            WriteLiteral(" grams\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Fact about ");
#nullable restore
#line 45 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
                  Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
       Write(Html.DisplayFor(model => model.IngredientFact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<p>You can find this ingredient in :</p>\r\n");
#nullable restore
#line 53 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
 if(Model.Recipes != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
     foreach(var recipe in Model.Recipes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f2daa179cc8c2b3200d60181889e956982539309692", async() => {
#nullable restore
#line 58 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
                                                                                         Write(recipe.Recipe.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
                                                               WriteLiteral(recipe.Recipe.Id);

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
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 60 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f2daa179cc8c2b3200d60181889e9569825393012973", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\Simona\Desktop\FEIT\6semestar\ServerskiWeb(.NET)\ASP.NET-recipesApp\HealthyRecipes\HealthyRecipes\Views\Ingredients\Details.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f2daa179cc8c2b3200d60181889e9569825393015176", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthyRecipes.Models.Ingredient> Html { get; private set; }
    }
}
#pragma warning restore 1591
