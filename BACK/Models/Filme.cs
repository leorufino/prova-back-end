using System;

namespace BACK.Models
{
    public class Filme
    {
        //Construtor
        public Filme() => CreatedAt = DateTime.Now;

        //Atributos
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sinopse { get; set; }
        public double Nota { get; set; }
        public DateTime CreatedAt { get; set; }

        //ToString

        public override string ToString() =>
            $"Nome: {Nome} | Sinopse: {Sinopse} | Nota: {Nota} | Criado em: {CreatedAt}";
    }
}