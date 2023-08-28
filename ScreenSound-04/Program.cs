using ScreenSound_04.Mpdelos;
using System.Text.Json;
using ScreenSound_04.Filtros;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        LinqFilter.FiltrarMusicasPelaTonalinade(musicas, "F#");
        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);  
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Lil Nas X");
        //LinqFilter.FiltrarMusicasPeloAno(musicas, 2012);


        //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);
        //musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        //var musicasPreferidasDoThiago = new MusicasPreferidas("Titi");
        //musicasPreferidasDoThiago.AdicionarMusicasFavoritas(musicas[500]);
        //musicasPreferidasDoThiago.AdicionarMusicasFavoritas(musicas[762]);
        //musicasPreferidasDoThiago.AdicionarMusicasFavoritas(musicas[25]);
        //musicasPreferidasDoThiago.AdicionarMusicasFavoritas(musicas[8]);
        //musicasPreferidasDoThiago.AdicionarMusicasFavoritas(musicas[800]);

        
        //musicasPreferidasDoThiago.ExibirMusicasFavoritas();
        //musicasPreferidasDoThiago.GerarArquivoJson();
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }


}