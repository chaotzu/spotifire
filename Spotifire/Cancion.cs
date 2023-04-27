using System;
namespace Spotifire
{
    /// <summary>
    /// Representa una canción con título, artista y duración.
    /// </summary>
    public class Cancion
    {

        /// <summary>
        /// Obtiene o establece el título de la canción.
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Obtiene o establece el artista de la canción.
        /// </summary>
        public string Artista { get; set; }

        /// <summary>
        /// Obtiene o establece la duración de la canción en segundos.
        /// </summary>
        public int Duracion { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Cancion con el título, artista y duración especificados.
        /// </summary>
        /// <param name="titulo">El título de la canción.</param>
        /// <param name="artista">El artista de la canción.</param>
        /// <param name="duracion">La duración de la canción en segundos.</param>
        public Cancion(string titulo, string artista, int duracion)
        {
            Titulo = titulo;
            Artista = artista;
            Duracion = duracion;
        }
    }

}

