using System;
using System.Collections.Generic;

namespace Music
{
    internal class Musica
    {
        public string nome;
        public string autor;
        public string gravadora { get; private set; }

        public Musica(string nome, string autor)
        {
            this.nome = nome;
            this.autor = autor;
        }
    }

    public class Playlist
    {
        private List<Musica> play; // Usar List<Musica> para facilitar a adição
        public string dono;

        public Playlist()
        {
            play = new List<Musica>();
        }

        public void Adc(string nome, string autor)
        {
            Console.WriteLine("Quantas músicas deseja adicionar? ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite o nome da música:");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o autor da música:");
                autor = Console.ReadLine();

                Musica novaMusica = new Musica(nome, autor);
                play.Add(novaMusica); // Adiciona a música à lista
                Console.WriteLine($"A música '{nome}' foi adicionada");
            }
        }

        public void Tocar()
        {
            if (play.Count == 0)
            {
                Console.WriteLine("A playlist está vazia.");
                return;
            }

            Random random = new Random();
            int indice = random.Next(play.Count);
            Musica musicaAleatoria = play[indice];

            Console.WriteLine($"Tocando: {musicaAleatoria.nome} - {musicaAleatoria.autor}");

            
        }
    }
}
