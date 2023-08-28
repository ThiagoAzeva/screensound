

namespace ScreenSound_04;

internal class Personagem
{
    public string Nome { get; set; }
    public List<string>? aliases { get; set; }

    public void ExibirApelidosDaPersonagem()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine("Apelidos:");
        foreach(string apelido in aliases) 
        { 
            Console.WriteLine($"- {apelido}");
        }
    }
}


