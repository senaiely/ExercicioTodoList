#pragma checksum "C:\Users\50403868858\Desktop\Vilyn\ProjetoTsuka\Views\Tarefas\CadastroTarefas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cab32f8ebe71bcdd06bc26773afa2f080723a697"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefas_CadastroTarefas), @"mvc.1.0.view", @"/Views/Tarefas/CadastroTarefas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarefas/CadastroTarefas.cshtml", typeof(AspNetCore.Views_Tarefas_CadastroTarefas))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cab32f8ebe71bcdd06bc26773afa2f080723a697", @"/Views/Tarefas/CadastroTarefas.cshtml")]
    public class Views_Tarefas_CadastroTarefas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 522, true);
            WriteLiteral(@"<form action=""/Tarefas/CadastroTarefas"" method=""POST"">

<label>
    Nome
    <input type=""text"" name=""nome"">
</label>

<label>
    Descrição
    <input type=""text"" name=""descricao"">
</label>

<label>
    Tipo
    <select  name=""tipo"">
        <option value="""">Selecionar</option>
        <option value=""parafazer"">Para fazer</option>
        <option value=""fazendo"">Fazendo</option>
        <option value=""feito"">Feito</option>
    </select>
</label>

<button type=""submit"">Salvar</button>

</form>");
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