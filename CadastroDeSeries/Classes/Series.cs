using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDeSeries
{
    public class Series : EntidadeBase
    {
        private Genero _Genero { get; set; }

        private string _Titulo { get; set; }

        private string _Descricao { get; set; }

        private int _Ano { get; set; }

        private bool _Excluido { get; set; }

        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this._Genero = genero;
            this._Titulo = titulo;
            this._Descricao = descricao;
            this._Ano = ano;
            this._Excluido = false;
        }


        public string retornaTitulo()
        {
            return this._Titulo;
        }


        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this._Excluido = true;
        }


        public bool retornaExcluido()
        {
            return this._Excluido;
        }
        public override string ToString()
        {
            //Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore3.1
            return $"Gênero: {_Genero + Environment.NewLine} "
                + $"Titulo: {_Titulo + Environment.NewLine} "
                +$"Descrição: {_Descricao + Environment.NewLine} " 
                + $"Ano de início: {_Ano + Environment.NewLine} "; 
        }
    }
}
