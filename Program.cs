class Program
{
    static void Main(string[] args)
    {
        List<Midia> midias = new List<Midia> {
        new Filme("Scarface", 1984, "Brian de Palma", Filme.GeneroTipo.Acao),
        new Livro("Steve Jobs", 2010, "Walter Isaacson", 624),
        new Filme("Meu Malvado Favorito", 2010, "Pierre Coffin", Filme.GeneroTipo.Comedia),
        new Livro("Diário de um banana", 2007, "Jeff Kinney", 180) };

        midias.RemoveAll(p => p.Ano < 2000);
        
        foreach (var item in midias)
        {
            System.Console.WriteLine(item);
        }
    }
}