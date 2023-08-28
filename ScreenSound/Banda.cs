class Banda
{
    private List<Album> albums = new List<Album>();

    // para facilitar a criação de construtores é só escrever "ctor" e apertgar tab.
    public Banda(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach(Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}