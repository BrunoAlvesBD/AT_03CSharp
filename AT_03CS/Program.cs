namespace AT_03CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            biblioteca.carregarDoados("biblioteca.txt");

            Livro livro1 = new Livro("O Senhor dos Anéis,", "J.R.R. Tolkien", "1954");
            Livro livro2 = new Livro("O Último Desejo,", "Andrzej Sapkowski", "1993");
            Revista revista1 = new Revista("Famicom Tsushin,", "Weekly Famitsu", "1986");

            biblioteca.adicionarItem(livro1);
            biblioteca.adicionarItem(livro2);
            biblioteca.adicionarItem(revista1);

            biblioteca.exibirItens();

            biblioteca.realizarEmprestimo(revista1 );
            biblioteca.realizarEmprestimo(livro2 );

            livro2.devolver();
            revista1.devolver();

            biblioteca.salvarDados("biblioteca.txt");
            

            Console.ReadLine();
        }
    }
}
