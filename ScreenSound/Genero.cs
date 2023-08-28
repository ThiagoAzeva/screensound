class Genero
{
    
    List<Genero> generos = new List<Genero>();

    public Genero(string nome, string descricaoGenero)
    {
        Nome = nome;
        DescricaoGenero = descricaoGenero;
    }

    public string Nome { get;  }
    public string DescricaoGenero { get;  }
    
}