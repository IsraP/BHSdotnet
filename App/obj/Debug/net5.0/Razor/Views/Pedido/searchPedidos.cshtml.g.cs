#pragma checksum "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccef0e5fb4366a2f65bb2ea77f3593e2d751d54c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_searchPedidos), @"mvc.1.0.view", @"/Views/Pedido/searchPedidos.cshtml")]
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
#line 1 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/_ViewImports.cshtml"
using App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/_ViewImports.cshtml"
using App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccef0e5fb4366a2f65bb2ea77f3593e2d751d54c", @"/Views/Pedido/searchPedidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12334568134fabec32ff1911f23453426e7f6405", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_searchPedidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Model.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card card-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "searchPedidos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "restorePedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "removePedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "showPreviousPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "searchPreviousPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "searchNextPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
  
    ViewData["Title"] = "Pedidos - Pesquisa";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row justify-content-center\">\n    <div class=\"col-12 col-md-10 col-lg-8\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccef0e5fb4366a2f65bb2ea77f3593e2d751d54c7900", async() => {
                WriteLiteral(@"
            <div class=""card-body row no-gutters align-items-center"">
                <div class=""col-auto"">
                    <i class=""fas fa-search h4 text-body""></i>
                </div>
                <div class=""col"">
                    <input name=""query"" class=""form-control form-control-lg form-control-borderless""
                        placeholder=""Encontre um pedido"">
                </div>
                <div class=""col-auto"">
                    <button class=""btn py-2 btn-orange"" type=""submit"">Pesquisar</button>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n<h3 class=\"my-3\">Resultados para a pesquisa \"");
#nullable restore
#line 23 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                                        Write(ViewBag.query);

#line default
#line hidden
#nullable disable
            WriteLiteral("\":</h3>\n<div class=\"row row-cols-1 row-cols-xs-2 row-cols-sm-2 row-cols-lg-4 g-3\">\n");
#nullable restore
#line 25 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
     foreach (var pdo in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-lg-3 col-xs-12 col-sm-6 col-md-4 my-3"">
            <div class=""card h-100 shadow-sm""> <img
                src=""https://www.freepnglogos.com/uploads/notebook-png/download-laptop-notebook-png-image-png-image-pngimg-2.png""
                class=""card-img-top"" alt=""XXXX"">
                <div class=""card-body"">
                    <div class=""clearfix mb-3"">
");
#nullable restore
#line 33 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                         if (pdo.Status == "A")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"float-start badge rounded-pill bg-success\">\n                                Ativo\n                            </span>\n");
#nullable restore
#line 38 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"float-start badge rounded-pill bg-danger\">\n                                Excluido\n                            </span>\n");
#nullable restore
#line 44 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"float-end price-hp\">R$ ");
#nullable restore
#line 45 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                                                       Write(pdo.Valorpedido.ToString().Replace(".", ","));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </div>\n                    <h5 class=\"card-title\">");
#nullable restore
#line 47 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                                      Write(pdo.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <div class=\"text-center my-4\">\n                        <a href=\"#\" class=\"btn btn-warning\" data-toggle=\"modal\" data-target=\"#");
#nullable restore
#line 49 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                                                                                          Write($"modal{pdo.Codigo}");

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                            Ver mais\n                        </a>\n                    </div>\n                </div>\n            </div>\n        </div>\n        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2490, "\"", 2518, 1);
#nullable restore
#line 56 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
WriteAttributeValue("", 2495, $"modal{pdo.Codigo}", 2495, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2533, "\"", 2562, 1);
#nullable restore
#line 56 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
WriteAttributeValue("", 2551, pdo.Codigo, 2551, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\">\n            <div class=\"modal-dialog modal-lg\">\n                <div class=\"modal-content\">\n                    <div class=\"modal-header\">\n                        <h5 class=\"modal-title\">");
#nullable restore
#line 60 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                                           Write(pdo.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - R$ ");
#nullable restore
#line 60 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                                                               Write(pdo.Valorpedido.ToString().Replace(".", ","));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <ul>
");
#nullable restore
#line 67 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                             foreach (var it in pdo.Itens)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 69 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                               Write(it.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 70 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\n                    </div>\n                    <div class=\"modal-footer\">\n                        <div");
            BeginWriteAttribute("class", " class=\"", 3452, "\"", 3460, 0);
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 75 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                             if (@pdo.Status == "A")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"modal\"\n                            data-target=\"#");
#nullable restore
#line 78 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                                      Write($"excluir{pdo.Codigo}");

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Excluir</button>\n");
#nullable restore
#line 79 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccef0e5fb4366a2f65bb2ea77f3593e2d751d54c17622", async() => {
                WriteLiteral("Restaurar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                                                                WriteLiteral(pdo.Codigo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 84 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\"");
            BeginWriteAttribute("onclick", "\n                                onclick=\"", 4131, "\"", 4211, 3);
            WriteAttributeValue("", 4173, "hideModal(`", 4173, 11, true);
#nullable restore
#line 86 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
WriteAttributeValue("", 4184, $"excluir{pdo.Codigo}", 4184, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4209, "`)", 4209, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Fechar</button>\n                        </div>\n                        <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 4305, "\"", 4335, 1);
#nullable restore
#line 88 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
WriteAttributeValue("", 4310, $"excluir{pdo.Codigo}", 4310, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <div class=\"card card-body\">\n                                Deseja excluir o pedido ");
#nullable restore
#line 90 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                                                   Write(pdo.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("?\n                            </div>\n                            <div class=\"card card-footer\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccef0e5fb4366a2f65bb2ea77f3593e2d751d54c21910", async() => {
                WriteLiteral("Excluir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                                                               WriteLiteral(pdo.Codigo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 101 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<nav aria-label=\"pagination\" class=\"d-flex justify-content-center\">\n    <ul class=\"pagination d-flex\">\n");
#nullable restore
#line 105 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
         if (ViewBag.page <= 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item disabled\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccef0e5fb4366a2f65bb2ea77f3593e2d751d54c25114", async() => {
                WriteLiteral("\n                    <span aria-hidden=\"true\">&laquo;</span>\n                    <span class=\"sr-only\">Previous</span>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                   WriteLiteral(ViewBag.page);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                                                 WriteLiteral(ViewBag.query);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-query", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n            </li>\n");
#nullable restore
#line 115 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccef0e5fb4366a2f65bb2ea77f3593e2d751d54c28730", async() => {
                WriteLiteral("\n                    <span aria-hidden=\"true\">&laquo;</span>\n                    <span class=\"sr-only\">Previous</span>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                                                                                                WriteLiteral(ViewBag.page);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                    WriteLiteral(ViewBag.query);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-query", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n            </li>\n");
#nullable restore
#line 126 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccef0e5fb4366a2f65bb2ea77f3593e2d751d54c32386", async() => {
                WriteLiteral("\n                <span aria-hidden=\"true\">&raquo;</span>\n                <span class=\"sr-only\">Next</span>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                                                                                        WriteLiteral(ViewBag.page);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "/home/israel/Documents/Code/IPdotnet/BHSdotnet/App/Views/Pedido/searchPedidos.cshtml"
                    WriteLiteral(ViewBag.query);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-query", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["query"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </li>\n    </ul>\n</nav>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Model.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
