using System;
namespace Spotifire
{
    /// <summary>
    /// Representa un álbum musical con título, artista, año de lanzamiento y una lista de canciones.
    /// </summary>
    public class Album
    {

        /// <summary>
        /// Obtiene o establece el título del álbum.
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Obtiene o establece el artista del álbum.
        /// </summary>
        public string Artista { get; set; }

        /// <summary>
        /// Obtiene o establece el año de lanzamiento del álbum.
        /// </summary>
        public int Anio { get; set; }

        /// <summary>
        /// Obtiene o establece una lista de canciones del álbum.
        /// </summary>
        public List<Cancion> Canciones { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Album con el título, artista y año de lanzamiento especificados.
        /// </summary>
        /// <param name="titulo">El título del álbum.</param>
        /// <param name="artista">El artista del álbum.</param>
        /// <param name="anio">El año de lanzamiento del álbum.</param>
        public Album(string titulo, string artista, int anio)
        {
            Titulo = titulo;
            Artista = artista;
            Anio = anio;
            Canciones = new List<Cancion>();
        }

        /// <summary>
        /// Agrega una canción a la lista de canciones del álbum.
        /// </summary>
        /// <param name="cancion">La canción a agregar.</param>
        public void AgregarCancion(Cancion cancion)
        {
            Canciones.Add(cancion);
        }
    }


}

