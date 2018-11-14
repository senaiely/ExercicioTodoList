using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoTsuka.Model;

namespace ProjetoTsuka.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ActionResult Cadastro(){
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(IFormCollection form){
            UsuarioModel usuariocadastrado = new UsuarioModel();

            usuariocadastrado.Id = 1;
            usuariocadastrado.Nome = form["nome"];
            usuariocadastrado.Email = form["email"];
            usuariocadastrado.Senha = form["senha"];
            usuariocadastrado.Tipo = form ["tipo"];
            usuariocadastrado.DataCriacao = DateTime.Now;

            using(StreamWriter sw = new StreamWriter("usuarios.csv", true))
            sw.WriteLine($"{usuariocadastrado.Id};{usuariocadastrado.Nome};{usuariocadastrado.Email};{usuariocadastrado.Senha};{usuariocadastrado.Tipo};{usuariocadastrado.DataCriacao}");
            
            return View();
        }
    }
}