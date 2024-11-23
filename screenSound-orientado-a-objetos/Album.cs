class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ListarMusicas()
    {
        Console.WriteLine($"Lista de M�sicas do �lbum: {Nome}");
        foreach(Musica musica in musicas)
        {
            Console.WriteLine($"{musica.Nome} \n");
        }
        Console.WriteLine($"Dura��o total do �lbum: {DuracaoTotal}");
    }
}

