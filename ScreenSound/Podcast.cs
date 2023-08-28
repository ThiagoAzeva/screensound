class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisidios => episodios.Count;

  public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDatalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n"); 
        foreach(Episodio episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este podcast possui {TotalEpisidios} episodios.");
    }
}