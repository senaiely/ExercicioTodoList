using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoTsuka.Model;

namespace ProjetoTsuka.Controllers
{
    public class TarefasController : Controller
    {
        [HttpGet]
        public ActionResult CadastroTarefas(){
            return View();
        }

        [HttpPost]
        public ActionResult CadastroTarefas(IFormCollection form){

            TarefasModel tarefacadastrada = new TarefasModel();

            tarefacadastrada.Id = 1;
            tarefacadastrada.Nome = form["nome"];
            tarefacadastrada.Descricao = form["descricao"];
            tarefacadastrada.Tipo = form["tipo"];
            tarefacadastrada.IdUsuario = "1";
            tarefacadastrada.DataCriacao = DateTime.Now;

            using (StreamWriter usuario = new StreamWriter ("tarefas.csv", true))
            usuario.WriteLine($"{tarefacadastrada.Id};{tarefacadastrada.Nome};{tarefacadastrada.Descricao};{tarefacadastrada.Tipo};{tarefacadastrada.IdUsuario};{tarefacadastrada.DataCriacao}");


            return View();
        }

    }
}