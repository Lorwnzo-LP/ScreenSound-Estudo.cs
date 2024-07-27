Album albumGorillaz = new Album("Demon Days");
albumGorillaz.genero = new Genero { Nome = "Rock alternativo" };
Banda gorillaz = new Banda("Gorillaz");

gorillaz.AdicionarAlbum(albumGorillaz);
gorillaz.ExibirDiscografia();

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

albumGorillaz.ExibirInformacoesCompletas();

