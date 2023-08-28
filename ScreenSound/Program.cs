/* Para criar um objeto em C# é muito similar a java:
 1. cria-se um novo item pelo gerenciador  de solução.
 2. desenvolve uma classe.
 3. puxa a classe e cria um objeto com a estrutura abaixo.
Musica musica1 = new Musica();*/
/*Para utilisar um objeto, voce precisa chamar esse objeto, e para utilizar os metodos dele utilizase ".".
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);
*/
//Banda queen = new Banda("Queen");

//Album albumDoQueen = new Album("A nigth at the opera");

//Musica musica1 = new Musica(queen, "love of my life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//* Uma maneira de deixar menos maçante e evitar escrever sempre o nome do objeto e ponto para add informações,
//  uma maneira mais tranquila de fazer é :
//   Pondo chaves no lugar do ponto e virgula
//    e incerindo diretamente as variaveis.
//    OBS: no final de cada variavel coloca-se virgula*/
//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponivel = false,

//};

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumDoQueen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQueen.ExibirMusicasDoAlbum();
//queen.ExibirDiscografia();

Episodio ep1 = new Episodio(1, "Rpg é legal!", 45);
ep1.AdicionarConvidados("Titi");
ep1.AdicionarConvidados("Shangs");
ep1.AdicionarConvidados("Nat");
ep1.AdicionarConvidados("Moy");


Episodio ep2 = new Episodio(2, "RTudo começa em uma taverna!", 60);
ep2.AdicionarConvidados("Titi");
ep2.AdicionarConvidados("Shangs");
ep2.AdicionarConvidados("Nat");



Podcast podcast = new("Titi", "Jogatiti");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDatalhes();