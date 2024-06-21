using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_03CS
{
    internal class Revista : ItemBiblioteca, IEmprestavel
    {
        public Revista(string titulo, string autor, string anoPublicacao) : base(titulo, autor, anoPublicacao)
        {
        }

        private bool emprestado = false;


        public override void devolver()
        {
            if (emprestado)
            {
                emprestado = false;
                Console.WriteLine($"Revista devolvida. ");
            }
            else
            {
                Console.WriteLine($"{Titulo} não está emprestado.");
            }

        }
        //metodo para emprestar, verifica se o livro não está emprestado, se não tiver, atribui true para o atributo
        public override void emprestar()
        {
            if (!emprestado)
            {
                emprestado = true;
                Console.WriteLine($"Revista: {Titulo} emprestada com sucesso.");
            }
            else
            {
                Console.WriteLine($"Revista {Titulo} já está emprestada.");
            }
        }
        //metodo para exibir as informações da revista
        public override void exibirInformacoes()
        {
            Console.WriteLine($"titulo: {Titulo}, autor: {Autor}, ano: {AnoPublicacao}");

        }
        //metodo para mostrar o prazo de emprestimo da revista
        public void obterPrazoDeDevolução()
        {
            Console.WriteLine("prazo para devolução: 7 dias.");
        }
        // metodo para verificar a disponibilidade da revista, vem da interface
        public void verificarDisponibilidade()
        {
            Console.WriteLine(emprestado ? "Revista indisponivel." : "Revista disponivel");

        }
    }
}

