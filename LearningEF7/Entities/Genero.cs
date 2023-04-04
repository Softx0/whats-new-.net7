namespace LearningEF7.API.Entities
{
    public class Genero
    {
        public int Id { get; set; }

        //Perdonamos el null
        public string Nombre { get; set; } = null!;

        public HashSet<Pelicula> Peliculas { get; set; } = new HashSet<Pelicula>();

    }
}
