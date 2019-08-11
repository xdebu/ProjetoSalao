using ProjetoSalaoAPI.Models.Enums;
using System;

namespace ProjetoSalaoAPI.Models
{
    public class Pessoas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public int Cpf { get; set; }
        public DateTime DataCad { get; set; }
        public TipoPessoa Tipo { get; set; }

        public Pessoas()
        {
        }

        public Pessoas(int id, string nome, DateTime dataNasc, int cpf, DateTime dataCad, TipoPessoa tipo)
        {
            Id = id;
            Nome = nome;
            DataNasc = dataNasc;
            Cpf = cpf;
            DataCad = dataCad;
            Tipo = tipo;
        }
    }
}
