public class Libro
{
    [GrapgQLDescription("Título del Libro")]
    public string Titulo { get; set; }

    [GrapgQLDescription("Compositor del Libro")]
    public Autor Autor { get; set; }
}
