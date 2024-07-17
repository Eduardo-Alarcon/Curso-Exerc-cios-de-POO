using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Music
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist();

            playlist.Adc("Billie Jean", "MIchael Jackson");


            playlist.Tocar();
            Console.ReadKey();
        }
    }
}
