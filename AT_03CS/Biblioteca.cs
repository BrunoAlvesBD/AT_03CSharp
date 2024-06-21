using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_03CS
{
    internal class Biblioteca
    {
        //a lista para armazenar os itens na biblioteca
        private List<ItemBiblioteca> itens;

        //construtor para inicializar a lista dos itens
        public Biblioteca()
        {
            itens = new List<ItemBiblioteca>();
        }

        //metodo que adiciona um item a biblioteca e mostra a mensagem de adicionado
        public void adicionarItem(ItemBiblioteca item)
        {
            itens.Add(item);
            Console.WriteLine($"Item {item.Titulo} adicionado a biblioteca");
        }

        //metod para remover o item da biblioteca e mostrar a mensagem de removido
        
        public void removerItem(ItemBiblioteca item)
        {
            //veifica se o item foi removido, se não foi, é por que não foi encontrado
            if (itens.Remove(item))
            {
                Console.WriteLine($"{item.Titulo} removido da biblioteca.");
            }
            else
            {
                Console.WriteLine($"{item.Titulo} não encontrado.");
            }

        }
        //metodo para exibir os itens na biblioteca
        public void exibirItens()
        {
            Console.WriteLine("Biblioteca:");
            foreach (var item in itens)
            {
                item.exibirInformacoes();
            }
        }
        //metodo para realizar o emprestimo do item
        public void realizarEmprestimo(ItemBiblioteca item)
        {
            item.emprestar();
        }

        //metodo para salvar as informações em um arquivo
        public void salvarDados(string arquivo)
        {
            //este é o escritor sendo declarado
            //o using garante o fechamento e a liberração do metodo StreamWriter
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                //foreach itera sobre todos os itens da biblioteca
                foreach (var item in itens)
                {
                    //variavel para determinar se é livro ou revista
                    string tipo = item is Livro ? "Livro" : "Revista";

                    //detalhando o formato que os arquivos serão escritos, seperados por ;.
                    sw.WriteLine($"{tipo}; {item.Titulo};{item.Autor};{item.AnoPublicacao}");
                }
            }
            Console.WriteLine("Dados salvos");
        }

        //metodo para carregar a lista de intens do arquivo
        public void carregarDoados(string arquivo)
        {
            try
            {
                //metodo  leitor também usando o 'using'
                using (StreamReader sr = new StreamReader(arquivo))
                {
                    string linha;
                    //lendo cada linha do arquivo até o final
                    while ((linha = sr.ReadLine()) != null)
                    {
                        //dividindo a linha separada por ;
                        var dados = linha.Split(';');
                        if (dados.Length == 4)
                        {
                            //extraindo as informações: tipo, titulo, autor e ano
                            string tipo = dados[0];
                            string titulo = dados[1];
                            string autor = dados[2];
                            string anoPublicacao = dados[3];

                            //cria um objeto do tipo apropriado, livro ou revista
                            if (tipo == "Livro")
                            {
                                adicionarItem(new Livro(titulo, autor, anoPublicacao));
                            }
                            else if (tipo == "Revista")
                            {
                                adicionarItem(new Revista(titulo, autor, anoPublicacao));
                            }
                        }
                    }
                }
                //mensagem para informar que os dados foram carregados
                Console.WriteLine("Dados carregados");
            }
            catch (FileNotFoundException)
            {
                //informa caso ocorra algum erro e o arquivo não é encontrado
                Console.WriteLine("arquivo não encontrado");
            }
        }

    }
}