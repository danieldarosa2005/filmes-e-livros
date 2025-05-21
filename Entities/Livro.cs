class Livro : Midia
{
    public string Autor { get; set; }
    public int Paginas { get; set; }
    public Livro(string titulo, int ano, string autor, int paginas) : base(titulo, ano)
    {
        Autor = autor;
        Paginas = paginas;
    }
    public override string ToString()
    {
        return base.ToString() + $" Autor: {Autor} Páginas: {Paginas}";
    }
}