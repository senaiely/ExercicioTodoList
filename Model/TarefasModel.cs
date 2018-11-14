using System;

namespace ProjetoTsuka.Model
{
    public class TarefasModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string IdUsuario { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}