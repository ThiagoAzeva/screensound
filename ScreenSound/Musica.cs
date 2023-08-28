/* Para que uma variavel fique visivel fora da classe, é necessario por como publica (public)*/
 class Musica
{
    // A baixo segue exemplo de construrpr em C#. no exemplo a baixo, ele serve como limitador, fazendo com que nenhuma musica seja vinculada a outra banda.
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get;  }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    //Atalho para Criar uma propriedade em C# é escrevert prop em seguida apertar tab e completar a linha.
    public string DescricaoResumida => 
        $" a musica {Nome} pertence ao artista/banda {Artista}!";

    public Genero Genero { get; set; }
    
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano.");
        }
        else
        {
            Console.WriteLine("Adiquira o plano Plus+");
        }

    }

}

