using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_03CS
{
    internal class Livro : ItemBiblioteca, IEmprestavel
    {

        public Livro(string titulo, string autor, string anoPublicacao) : base(titulo, autor, anoPublicacao)
        {
        }

        //atributo para indicar se o livro está emprestado, iniciando com falor false
        private bool emprestado = false;


        //metodo para devolver o livro
        //verifica se ele está emprestado, se tiver, atribui o valor false para oatributo empretstado
        public override void devolver()
        {
            if (emprestado) 
            { 
                emprestado = false;
                Console.WriteLine($"Titulo devolvido. ");
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
                Console.WriteLine($"Livro: {Titulo} emprestado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Livro {Titulo} já está emprestado.");
            }
        }

        //metodo para exibir as informações do livro
        public override void exibirInformacoes()
        {
            Console.WriteLine($"titulo: {Titulo}, autor: {Autor}, ano: {AnoPublicacao}");

        }

        //metodo para mostrar o prazo de emprestimo do livro
        public void obterPrazoDeDevolução()
        {
            Console.WriteLine("prazo para devolução: 21 dias.");
        }

        // metodo para verificar a disponibilidade do livro, vem da interface
        public void verificarDisponibilidade()
        {
            Console.WriteLine(emprestado ? "livro indisponivel." : "livro disponivel");
            
        }
    }
}
