
namespace NavajaSuiza.Tema5.Ejercicio2
{
    /// <summary>
    /// calcula la media del vector
    /// </summary>
    class LecturaVector
    {
        /// <summary>
        /// Constante que da el tope al vector
        /// </summary>
        const int KTam = 10;

        /// <summary>
        /// Recorre el vector entero y devuelve
        /// la media.
        /// </summary>
        /// <param name="vector">el vector.</param>
        /// <returns>Devuelve la media del vector entero</returns>
        public int FMediaVector(int[] vector)
        {
            int media, i;
            media = 0;

            for (i = 0; i < vector.Length; i++)
            {
                media = media + vector[i];
            }
            media = media / KTam;

            return media;
        }
    }
}
