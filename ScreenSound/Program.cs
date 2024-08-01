
//Instância da classe Album.
Album albumGorillaz = new Album("Demon Days");
albumGorillaz.genero = new Genero { Nome = "Rock alternativo" };
//Instância da classe Banda.
Banda gorillaz = new Banda("Gorillaz");

gorillaz.AdicionarAlbum(albumGorillaz);
gorillaz.ExibirDiscografia();

//Instância de classe Musica.
Musica musica1 = new Musica(gorillaz, "Dare")
{
    Duracao = 240,
    Disponivel = true,
};
Musica musica2 = new Musica(gorillaz, "White Light")
{
    Duracao = 240,
    Disponivel = false,
};

albumGorillaz.AdicionarMusica(musica1);
albumGorillaz.AdicionarMusica(musica2);

//Exibindo informações.
albumGorillaz.ExibirInformacoesCompletas();

//Novas Instâncias de Album, Banda e Musica.
Album albumSinner = new Album("Sinner");
Banda drowningPool = new Banda("Drowning Pool");

Musica bodies = new Musica(drowningPool, "bodies")
{
    Duracao = 210,
    Disponivel = true,
};

albumSinner.AdicionarMusica(bodies);
albumSinner.ExibirInformacoesCompletas();

Console.WriteLine("\n\n");

//Instância de Podcast.
Podcast HelloPodcast = new Podcast("Lorenzo", "Hello World Podcast");
//Instância de Episódio e adição de convidados.
Episodio episodio1 = new Episodio(400,"Hello world, Nosso Primeiro Podcast!!","O primeiro episódio do mais novo Podcast sobre programação!",1);
episodio1.AdicionarConvidadosOff("Lorenzo 2");
episodio1.AdicionarConvidadosOff("Lorenzo 3");
HelloPodcast.AdicionarEpisodio(episodio1);

//Instância de Episódio e adição de convidados.
Episodio episodio2 = new Episodio(500, "Primeiro programa em C#!!", "Ensinando a produzir seu primeiro programa em C#!",2);
episodio2.AdicionarConvidadosOff("Lorenzo Programador");
episodio2.AdicionarConvidadosOff("Sapinha");
HelloPodcast.AdicionarEpisodio(episodio2);


//Exibindo detalhes.
HelloPodcast.ExibirDetalhes();
