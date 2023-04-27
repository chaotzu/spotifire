using System;
using System.Collections.Generic;
using Spotifire;

public class Program
{
    public static void Main(string[] args)
    {
        // Crear algunas canciones
        Cancion c1 = new Cancion("Bohemian Rhapsody", "Queen", 367);
        Cancion c2 = new Cancion("Stairway to Heaven", "Led Zeppelin", 480);
        Cancion c3 = new Cancion("Hotel California", "Eagles", 390);

        // Crear un álbum y agregar algunas canciones
        Album album = new Album("Greatest Hits", "Queen", 1981);
        album.AgregarCancion(c1);
        album.AgregarCancion(c2);

        // Crear una lista de reproducción y agregar algunas canciones y un álbum completo
        ListaReproduccion lista = new ListaReproduccion("Mi Lista");
        lista.AgregarElemento(c1);
        lista.AgregarElemento(c3);
        lista.AgregarElemento(album);

        // Mostrar el contenido de la lista de reproducción
        Console.WriteLine($"Lista de reproducción: {lista.Nombre}");
        foreach (object elemento in lista.Elementos)
        {
            if (elemento is Cancion cancion)
            {
                Console.WriteLine($"- Canción: {cancion.Titulo} ({cancion.Artista}) - {cancion.Duracion} segundos");
                Console.ReadKey();
            }
            else if (elemento is Album albumLista)
            {
                Console.WriteLine($"- Álbum: {albumLista.Titulo} ({albumLista.Artista}) - {albumLista.Anio}");
                foreach (Cancion cancionAlbum in albumLista.Canciones)
                {
                    Console.WriteLine($"  - Canción: {cancionAlbum.Titulo} ({cancionAlbum.Artista}) - {cancionAlbum.Duracion} segundos");
                    Console.ReadKey();
                }
            }
        }
    }
}
