using System;
namespace Spotifire
{
    /// <summary>
    /// Representa una lista de reproducción con un nombre y una lista de elementos.
    /// </summary>
    public class ListaReproduccion
    {

        /// <summary>
        /// Obtiene o establece el nombre de la lista de reproducción.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece una lista de elementos de la lista de reproducción.
        /// </summary>
        public List<object> Elementos { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase ListaReproduccion con el nombre especificado.
        /// </summary>
        /// <param name="nombre">El nombre de la lista de reproducción.</param>
        public ListaReproduccion(string nombre)
        {
            Nombre = nombre;
            Elementos = new List<object>();
        }

        /// <summary>
        /// Agrega un elemento a la lista de reproducción.
        /// </summary>
        /// <param name="elemento">El elemento a agregar.</param>
        public void AgregarElemento(object elemento)
        {
            Elementos.Add(elemento);
        }
    }

}

