#pragma checksum "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8a365cda1484d40d02a4270530c15076c732440"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
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
#line 1 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\_ViewImports.cshtml"
using ControleDeContatos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\_ViewImports.cshtml"
using ControleDeContatos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8a365cda1484d40d02a4270530c15076c732440", @"/Views/Contato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e15e6b3a3754a4b191426234179754bca81c2c7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContatoModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Criar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApagarConfirmacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
  
    ViewData["Title"] = "Listagem de Cadastros";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <div class=\"d-grid gap-2 d-md-flex justify-content-md-start\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8a365cda1484d40d02a4270530c15076c7324406148", async() => {
                WriteLiteral("Adicionar um Novo Contato  <i class=\"fa-solid fa-plus\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <h1 class=\"display-4\">Lista de Cadastros</h1>\r\n    <br />\r\n\r\n");
#nullable restore
#line 13 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
     if (TempData["MensagemSucesso"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\" role=\"alert\">\r\n            Operação Realizada com Sucesso!\r\n            ");
#nullable restore
#line 17 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
       Write(TempData["MensagemSucesso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
     if (TempData["MensagemErro"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\" role=\"alert\">\r\n            Operação Apresentou Erro!\r\n            ");
#nullable restore
#line 25 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
       Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <br />
    <table class=""table"" id=""table-contatos"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Nome</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Celular</th>             
                <th scope=""col"">Nacionalidade</th>
                <th scope=""col"">CEP</th>
                <th scope=""col"">Estado</th>
                <th scope=""col"">Cidade</th>
                <th scope=""col"">Logradouro</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 46 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
             if (Model != null && Model.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                 foreach (ContatoModel contato in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 51 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                                   Write(contato.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>                       \r\n                        <td>");
#nullable restore
#line 52 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                       Write(contato.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                       Write(contato.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                       Write(contato.Celular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                        <td>");
#nullable restore
#line 55 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                       Write(contato.Nacionalidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                       Write(contato.CEP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                       Write(contato.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 58 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                       Write(contato.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 59 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                       Write(contato.Logradouro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                         <td>\r\n                            <div class=\"text-white\" role=\"group\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8a365cda1484d40d02a4270530c15076c73244013420", async() => {
                WriteLiteral("Apagar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                                                                          WriteLiteral(contato.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8a365cda1484d40d02a4270530c15076c73244016023", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                                                                             WriteLiteral(contato.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        \r\n                    </tr>\r\n");
#nullable restore
#line 68 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\dougl\source\repos\exaltare\Estudos\ControleDeContatos\Views\Contato\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContatoModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
