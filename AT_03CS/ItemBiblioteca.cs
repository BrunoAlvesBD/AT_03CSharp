using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_03CS
{
    internal abstract class ItemBiblioteca
    {
        //atributos que armazenam as informações do item da biblioteca
        private string _titulo;
        private string _autor;
        private string _anoPublicacao;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public string AnoPublicacao
        {
            get { return _anoPublicacao; }
            set { _anoPublicacao = value; }
        }

        //construtor para inicializar os atribuitop
        public ItemBiblioteca(string titulo, string autor, string anoPublicacao)
        {
            _titulo = titulo;
            _autor = autor;
            _anoPublicacao = anoPublicacao;
        }
       
        //metodos abstratos que são implementados pelas subclasses
        public abstract void emprestar();

        public abstract void devolver();

        public abstract void exibirInformacoes();
    }
}
