class Filme : Midia
{
    public string Diretor { get; set; }
    public GeneroTipo Genero { get; set; }
    public enum GeneroTipo { Acao, Drama, Comedia, Terror }
    public Filme(string titulo, int ano, string diretor, GeneroTipo genero) : base(titulo, ano)
    {
        Diretor = diretor;
        Genero = genero;
    }
    public override string ToString()
    {
        return base.ToString() + $", Diretor: {Diretor}, Gênero: {Genero}";
    }
}