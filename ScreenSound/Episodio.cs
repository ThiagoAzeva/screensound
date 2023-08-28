class Episodio
{
    public Episodio( int ordem, string titulo, int duracao)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    private List<string> convidados = new();
    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo => $" EP: {Ordem}. {Titulo} ({Duracao} min) -  {string.Join(",", convidados)}";
    

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

}