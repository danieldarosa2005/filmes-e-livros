class Midia
{
    public string Titulo { get; set; }
    public int Ano { get; set; }
    public Midia(string titulo, int ano)
    {
        Titulo = titulo;
        Ano = ano;
    }
    public override string ToString()
    {
        return $"{Titulo} ({Ano})";
    }
}